// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArrSort2Lvl( int[,] arr )
{
	int m = arr.GetUpperBound(1) + 1;
	int n = arr.GetUpperBound(0) + 1;
	int tmp;

	for (int i = 0; i < n; i++)
	{
		tmp = arr[ i,0 ];
		for (int j = 0; j < m; j++)
		{
			for (int c = 1; c < m; c++)
			{
				if ( arr[i,c] > arr[i,c-1]  )
				{
					tmp = arr[i,c];
					arr[i,c] = arr[i,c-1];
					arr[i,c-1] = tmp;
				}
			}

		}
	}
	return arr;
}

int[,] myArr = MakeArr2Lvl( 4,4 );
ArrPrint2lvl( myArr );
Console.WriteLine("----------------");
myArr = ArrSort2Lvl( myArr );
ArrPrint2lvl( myArr );