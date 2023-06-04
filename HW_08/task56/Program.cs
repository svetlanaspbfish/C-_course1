// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindRowWithMinSumInArr2Lvl( int[,] arr )
{
	int m = arr.GetUpperBound(1) + 1;
	int n = arr.GetUpperBound(0) + 1;
	int resI = 0;
	int minSum = 0;
	int sumCurRow;

	for (int i = 0; i < n; i++)
	{
		sumCurRow = arr[i,0];

		for (int j = 1; j < m; j++)
		{
			sumCurRow += arr[i,j];
		}

		if ( i == 0 )
		{
			minSum = sumCurRow;
			resI = 0;
		}
		else
		{
			if ( sumCurRow < minSum )
			{
				minSum = sumCurRow;
				resI = i;
			}
		}
	}

	Console.WriteLine("Строка с минимальной суммой имеет индекс " + resI + ". Номер этой строки " + ( resI + 1 ) );
}

int[,] myArr = MakeArr2Lvl( 4,4 );
ArrPrint2lvl( myArr );

FindRowWithMinSumInArr2Lvl( myArr );