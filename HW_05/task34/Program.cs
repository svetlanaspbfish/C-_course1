// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] ArrCreate( int n = 1 )
{
	if ( n <= 0 ) n = 1;

	int[] arr = new int[n];

	for (int i = 0; i < n; i++)
	{
		arr[i] = new Random().Next(100,1000);
	}

	return arr;
}

int evenCount( int[] arr )
{
	int res = 0;

	foreach ( int item in arr )
	{
		if ( item % 2 == 0 ) res++;
	}

	return res;
}

void ArrPrint( int[] arr )
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write( $"{ arr[i] }, " );
	}

}

int[] myArr = ArrCreate( 4 );
int evenCountRes = evenCount( myArr );
ArrPrint( myArr );

Console.WriteLine( $"\nЧётных чисел в массиве: { evenCountRes }" );