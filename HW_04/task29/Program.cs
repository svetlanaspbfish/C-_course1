// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]

// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

int[] ArrCreate( int n = 1 )
{
	if ( n <= 0 ) n = 1;

	int[] arr = new int[n];

	for (int i = 0; i < n; i++)
	{
		arr[i] = new Random().Next(0,100);
	}

	return arr;
}

int[] myArr = ArrCreate(8);
ArrPrint(myArr);

void ArrPrint( int[] arr )
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write( $"{ arr[i] }, " );
	}

}