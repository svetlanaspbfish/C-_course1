// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет

int Prompt( string whatWePrompt = "число" )
{
	int curPrompt;

	Console.WriteLine($"Введите { whatWePrompt }");

	curPrompt = int.Parse(Console.ReadLine());

	return curPrompt;
}

int[,] MakeArr2Lvl( int n, int m )
{
	int[,] arr = new int[n,m];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			arr[i,j] = new Random().Next(-100,100);
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

void GetElInArr2Lvl( int[,] arr, int i, int j )
{
	int m = arr.GetUpperBound(1);
	int n = arr.GetUpperBound(0);

	if ( i > n || j > m || i < 0 || j < 0 )
	{
		Console.WriteLine("Такого элемента нет");
	}
	else
	{
		Console.WriteLine("Значение элемента с этими координатами: " + arr[i,j]);
	}
}

int[,] myArr = MakeArr2Lvl( 5,6 );
ArrPrint2lvl( myArr );

int n = Prompt( " позицию Элемента. Первая координата:" );
int m = Prompt( "вторую координату:" );

GetElInArr2Lvl( myArr , n, m );