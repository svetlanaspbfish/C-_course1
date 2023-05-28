// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int evenPositionsSumCount( int[] arr )
{
	int res = 0, i = 0;

	foreach ( int item in arr )
	{
		if ( i % 2 == 0 ) res += item;
		i++;
	}

	return res;
}

int[] myArr = ArrCreate( 6 );
int evenCountRes = evenPositionsSumCount( myArr );
ArrPrint( myArr );

Console.WriteLine( $"\nСумма элементов, стоящих на нечётных позициях.: { evenCountRes }" );