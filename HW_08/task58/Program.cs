// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MatrixMultiplex( int[,] matrix1, int[,] matrix2 )
{
	int n1 = matrix1.GetUpperBound(0) + 1;
	int m1 = matrix1.GetUpperBound(1) + 1;

	int n2 = matrix2.GetUpperBound(0) + 1;
	int m2 = matrix2.GetUpperBound(1) + 1;

	if ( m1 != n2 )
	{
		Console.WriteLine("Такие матрицы нельзя перемножить.");
		return;
	}

	int[,] res = new int[n1,m2];

	for (int i = 0; i < n1; i++)
	{
		for (int j = 0; j < m2; j++)
		{
			res[i,j] = 0;
			for (int c = 0; c < m1; c++)
			{
				res[i,j] += matrix1[i,c] * matrix2[c,j];
			}
		}

	}

	Console.WriteLine("--------------");
	ArrPrint2lvl(res);
}

//int[,] matrix1 = MakeArr2Lvl( 4,4 );
//int[,] matrix1 = {{15,27},{18,10}};
int[,] matrix1 = {{2,4},{3,2}};
ArrPrint2lvl( matrix1 );

Console.WriteLine("---------------");

//int[,] matrix2 = MakeArr2Lvl( 4,4 );
//int[,] matrix2 = {{35},{16}};
int[,] matrix2 = {{3,4},{3,3}};
ArrPrint2lvl( matrix2 );

MatrixMultiplex( matrix1, matrix2 );