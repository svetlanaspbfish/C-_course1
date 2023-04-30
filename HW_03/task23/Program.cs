// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = PromptF();
int i = 1;

while ( i < n )
{
	PrintCube( i );
	Console.Write(",");
	i++;
}
PrintCube( i );
Console.WriteLine("");

int PromptF()
{
	Console.WriteLine("Введите число");

	int n = int.Parse( Console.ReadLine() );

	while ( PromptHasErrors( n ) )
	{
		Console.WriteLine("Ошибка ввода. Введите положительное число");
		n = int.Parse( Console.ReadLine() );
	}

	return n;
	
}

bool PromptHasErrors( int n )
{
	if ( n < 1 )
	{
		return true;
	}

	return false;
}

void PrintCube( int n )
{
	Console.Write( Math.Pow( n, 3) );
}