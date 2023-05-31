// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] MakeArr2Lvl( int n, int m )
{
	int[,] arr = new int[n,m];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			arr[i,j] = new Random().Next(-10,11);
		}
	}
	return arr;
}

void ArrPrint2lvl( int[,] arr )
{
	int m = arr.GetUpperBound(1) + 1;
	int n = arr.GetUpperBound(0) + 1;

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			Console.Write($"{ arr[i, j] }, ");
		}
		Console.WriteLine();
	}
}

void GetAvgInColsArr2Lvl( int[,] arr )
{
	int m = arr.GetUpperBound(1) + 1;
	int n = arr.GetUpperBound(0) + 1;

	double CurColumnAvg;

	for (int j = 0; j < m; j++)
	{
		CurColumnAvg = 0;
		for (int i = 0; i < n; i++)
		{
			CurColumnAvg += arr[i,j];
			//Console.Write($"{ arr[i, j] }, ");
		}
		CurColumnAvg = CurColumnAvg / n;
		Console.WriteLine( "Среднее арифметическое колонки с индексом " + j + " : " + CurColumnAvg );
	}

}

int[,] myArr = MakeArr2Lvl( 4,4 );
ArrPrint2lvl( myArr );

GetAvgInColsArr2Lvl( myArr );