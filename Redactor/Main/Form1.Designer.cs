namespace GR_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.lColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b0 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lSize = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lAdd = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.bDone = new System.Windows.Forms.Button();
            this.canselTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM1,
            this.TSM2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM1
            // 
            this.TSM1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadTSM,
            this.saveTSM});
            this.TSM1.Name = "TSM1";
            this.TSM1.Size = new System.Drawing.Size(57, 24);
            this.TSM1.Text = "Файл";
            // 
            // downloadTSM
            // 
            this.downloadTSM.Name = "downloadTSM";
            this.downloadTSM.Size = new System.Drawing.Size(216, 26);
            this.downloadTSM.Text = "Загрузить";
            this.downloadTSM.Click += new System.EventHandler(this.downloadTSM_Click);
            // 
            // saveTSM
            // 
            this.saveTSM.Name = "saveTSM";
            this.saveTSM.Size = new System.Drawing.Size(216, 26);
            this.saveTSM.Text = "Сохранить";
            this.saveTSM.Click += new System.EventHandler(this.saveTSM_Click);
            // 
            // TSM2
            // 
            this.TSM2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTSM,
            this.canselTSM});
            this.TSM2.Name = "TSM2";
            this.TSM2.Size = new System.Drawing.Size(77, 24);
            this.TSM2.Text = "Рисунок";
            // 
            // clearTSM
            // 
            this.clearTSM.Name = "clearTSM";
            this.clearTSM.Size = new System.Drawing.Size(216, 26);
            this.clearTSM.Text = "Очистить";
            this.clearTSM.Click += new System.EventHandler(this.clearTSM_Click);
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.lColor.Location = new System.Drawing.Point(3, 0);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(173, 20);
            this.lColor.TabIndex = 7;
            this.lColor.Text = "Цветовая  палитра";
            this.lColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Другой цвет";
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Location = new System.Drawing.Point(98, 36);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(30, 27);
            this.b0.TabIndex = 5;
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.RoyalBlue;
            this.b5.Location = new System.Drawing.Point(37, 3);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(28, 27);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.GreenYellow;
            this.b4.Location = new System.Drawing.Point(71, 3);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(28, 27);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Gold;
            this.b3.Location = new System.Drawing.Point(105, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(28, 27);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.OrangeRed;
            this.b2.Location = new System.Drawing.Point(139, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(28, 27);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Red;
            this.b1.Location = new System.Drawing.Point(3, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(28, 27);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 23);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(155, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.lSize.Location = new System.Drawing.Point(3, 0);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(129, 20);
            this.lSize.TabIndex = 0;
            this.lSize.Text = "Тощина линии";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lColor);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(618, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 97);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.b1);
            this.flowLayoutPanel3.Controls.Add(this.b5);
            this.flowLayoutPanel3.Controls.Add(this.b4);
            this.flowLayoutPanel3.Controls.Add(this.b3);
            this.flowLayoutPanel3.Controls.Add(this.b2);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.b0);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(173, 67);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lSize);
            this.flowLayoutPanel2.Controls.Add(this.trackBar1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(618, 125);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 68);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 427);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lAdd);
            this.flowLayoutPanel4.Controls.Add(this.cb1);
            this.flowLayoutPanel4.Controls.Add(this.bDone);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(618, 193);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(182, 100);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // lAdd
            // 
            this.lAdd.AutoSize = true;
            this.lAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.lAdd.Location = new System.Drawing.Point(3, 0);
            this.lAdd.Name = "lAdd";
            this.lAdd.Size = new System.Drawing.Size(122, 20);
            this.lAdd.TabIndex = 1;
            this.lAdd.Text = "Инструменты";
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(3, 23);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 24);
            this.cb1.TabIndex = 2;
            // 
            // bDone
            // 
            this.bDone.Location = new System.Drawing.Point(3, 53);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(99, 29);
            this.bDone.TabIndex = 3;
            this.bDone.Text = "Выполнить";
            this.bDone.UseVisualStyleBackColor = true;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // canselTSM
            // 
            this.canselTSM.Name = "canselTSM";
            this.canselTSM.Size = new System.Drawing.Size(216, 26);
            this.canselTSM.Text = "Отменить";
            this.canselTSM.Click += new System.EventHandler(this.canselTSM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(818, 502);
            this.MinimumSize = new System.Drawing.Size(818, 502);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM1;
        private System.Windows.Forms.ToolStripMenuItem downloadTSM;
        private System.Windows.Forms.ToolStripMenuItem saveTSM;
        private System.Windows.Forms.ToolStripMenuItem TSM2;
        private System.Windows.Forms.ToolStripMenuItem clearTSM;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lAdd;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button bDone;
        private System.Windows.Forms.ToolStripMenuItem canselTSM;
    }
}

