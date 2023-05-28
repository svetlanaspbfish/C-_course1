// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void ArrPrint( int[] arr )
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write( $"{ arr[i] }, " );
	}

}

int[] ArrCreate( int n = 1 )
{
	if ( n <= 0 ) n = 1;

	int[] arr = new int[n];

	for (int i = 0; i < n; i++)
	{
		arr[i] = new Random().Next(0,10);
	}

	return arr;
}

int getMin( int[] arr )
{
	int res = arr[0];

	foreach ( int item in arr )
	{
		if ( item < res ) res = item;
	}

	return res;
}

int getMax( int[] arr )
{
	int res = arr[0];

	foreach ( int item in arr )
	{
		if ( item > res ) res = item;
	}

	return res;
}

int[] myArr = ArrCreate( 6 );
int minInMyArr = getMin( myArr );
int maxInMyArr = getMax( myArr );
ArrPrint( myArr );

Console.WriteLine( $"\nРазница между максимальным и минимальным элементов массива: { maxInMyArr - minInMyArr }" );