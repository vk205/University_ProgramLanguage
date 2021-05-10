using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GR_2
{
    public partial class Form1 : Form
    {
        // ----- Инструменты для рисования -----

        private Bitmap map = new Bitmap(100, 100);
        private Bitmap mapClone = new Bitmap(100, 100);
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);

        // ----- Описания функций -----

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void GetInfoDelegate(StringBuilder sr);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OperationDelegate(byte[] r, byte[] g, byte[] b, int l);

        // ----- Инструменты для библиотек -----
        
        List<IntPtr> moduls = new List<IntPtr>();
        List<IntPtr> libs = new List<IntPtr>();
        List<OperationDelegate> operations = new List<OperationDelegate>();
        private int operationCount = 0;

        public Form1()
        {
            InitializeComponent();
            SetSize();
            SetColor();
            GetOperations();
            canselTSM.Enabled = false;
        }

        // ----- Работа с библитеками -----

        private void GetOperations()
        {
            string[] dllNames = Directory.GetFiles(".", "*.dll");
            if (dllNames.Length > 0)
            {
                foreach (var dllName in dllNames)
                {
                    IntPtr hModule = NativeMethods.LoadLibrary(dllName);
                    if (hModule == IntPtr.Zero) continue;

                    IntPtr intPtr = NativeMethods.GetProcAddress(hModule, "GetInfo");
                    GetInfoDelegate getInfo = Marshal.GetDelegateForFunctionPointer(intPtr, typeof(GetInfoDelegate)) as GetInfoDelegate;
                    StringBuilder s = new StringBuilder("");
                    getInfo(s);

                    IntPtr intPtr1 = NativeMethods.GetProcAddress(hModule, "Method");
                    OperationDelegate op = Marshal.GetDelegateForFunctionPointer(intPtr1, typeof(OperationDelegate)) as OperationDelegate;

                    operations.Add(op);
                    moduls.Add(intPtr1);
                    libs.Add(hModule);
                    operationCount++;

                    cb1.Items.Add(s.ToString());
                }
            }
            if (operationCount<=0)
            {
                MessageBox.Show("Не найдено ни одной библиотеки!");
                cb1.Enabled = false;
                flowLayoutPanel4.Visible = false;
            }
            else
            {
                cb1.SelectedIndex = 0;
            }
        }

        // ----- Начальная инициализация рабочего пространства -----

        private void SetColor()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            for (int i = 0; i < map.Width; i++)
                for (int j = 0; j < map.Height; j++)
                {
                    Color color = Color.White;
                    map.SetPixel(i, j, color);
                }
            pictureBox1.Image = map;
        }

        private void SetSize()
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        // ----- Рисование -----

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            canselTSM.Enabled = true;
            mapClone = (Bitmap)map.Clone();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }

            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        // ----- Основной функционал -----

        private void clearTSM_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
            canselTSM.Enabled = false;
        }

        private void downloadTSM_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image= Image.FromFile(openFileDialog1.FileName);

                    map = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                    graphics = Graphics.FromImage(map);
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void saveTSM_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
        
        private void canselTSM_Click(object sender, EventArgs e)
        {
            map = (Bitmap)mapClone.Clone();
            pictureBox1.Image = map;
            graphics = Graphics.FromImage(map);
            canselTSM.Enabled = false;
        }

        // ----- Дополнительный функционал -----

        private byte[] ImageToInt(int k)
        {
            int h = map.Height;
            int w = map.Width;
            byte[] tmp = new byte[w * h];

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    Color color = map.GetPixel(i, j);
                    switch (k)
                    {
                        case 0: tmp[i * h + j] = (byte)color.R; break;
                        case 1: tmp[i * h + j] = (byte)color.G; break;
                        case 2: tmp[i * h + j] = (byte)color.B; break;
                    }
                }

            return tmp;
        }

        private void IntToImage(byte[] r, byte[] g, byte[] b)
        {
            int h = map.Height;
            int w = map.Width;

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    byte R = r[i * h + j];
                    byte G = g[i * h + j];
                    byte B = b[i * h + j];

                    Color color = Color.FromArgb(R, G, B);
                    map.SetPixel(i, j, color);
                }
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            mapClone = (Bitmap)map.Clone();
            canselTSM.Enabled = true;

            byte[] r = ImageToInt(0);
            byte[] g = ImageToInt(1);
            byte[] b = ImageToInt(2);
            int index = cb1.SelectedIndex;

            operations[index](r, g, b, map.Width * map.Height);
            IntToImage(r, g, b);
            pictureBox1.Image = map;
            MessageBox.Show("Операция выполнена успешно!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(var hModule in libs)
            {
                bool result = NativeMethods.FreeLibrary(hModule);
            }
        }
    }

    // ----- Класс для прорисовки линий -----
    public class ArrayPoints
    {
        private int index = 0;
        private Point[] points;

        public ArrayPoints(int size)
        {
            if (size <= 0) size = 2;
            points = new Point[size];
        }

        public void SetPoint(int x, int y)
        {
            if (index >= points.Length) { ResetPoints(); }
            points[index] = new Point(x, y);
            index++;
        }

        public void ResetPoints() { index = 0; }

        public int GetCountPoints() { return index; }

        public Point[] GetPoints() { return points; }
    }

    // ----- Класс для работы с билиотеками -----
    static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
    }
}
