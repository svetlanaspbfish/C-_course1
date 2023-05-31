// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

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

int n = Prompt( "n" );
int m = Prompt( "m" );
int[,] myArr = MakeArr2Lvl( n,m );
ArrPrint2lvl( myArr );