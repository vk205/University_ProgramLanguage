#include<iostream>
#include<fstream>
#include<vector>
#include<queue>
#include <ctime>

using namespace std;

int main()
{
	vector< pair<int,int> > edges; // список ребер

	int n; // количество вершин
	int m; // количество ребер

// ************ Чтение из файла ************

	ifstream fin("test8.txt");
	fin >> n >> m;
	n = n + 1;
	for (int i = 0; i < m; i++)
	{
		int a, b;
		fin >> a >> b;
		edges.push_back(make_pair(a,b));
	}
	fin.close();

	srand(time(0));

// ************ Вычисление полустепеней (входящих) вершин ************

	queue<int> gq; // очередь для текущих вершин с 0 полустепенями

	vector<int> indegree(n, 0); // список полустепеней (входящих) вершин
	for (auto edg : edges) indegree[edg.second]++;
	for (int i = 0; i < n; i++) { if (indegree[i] == 0) gq.push(i); }

// ************ Топологическая сортировка ************

	vector<int>answer; // результирующий массив

	while (!gq.empty())
	{
		int item = gq.front();
		gq.pop();
		answer.push_back(item);
		
		// Уменьшение степеней соседних вершин
		for (int i = 0; i < m; i++)
		{
			if (edges[i].first == item)
			{
				int to = edges[i].second;
				indegree[to]--;
				if (indegree[to] == 0) gq.push(to);
			}
		}
	}

	cout << "runtime = " << clock() / 1000.0 <<" ms\n";

// ************ Вывод полученного результата ************

	if (answer.size() != n )	{ cout << "Topological sorting imbosible.\n"; }
	else { for (auto c : answer) cout << c << " "; cout << endl; }
}