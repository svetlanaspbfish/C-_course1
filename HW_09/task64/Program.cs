// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt( string whatWePrompt = "число" )
{
	int curPrompt;

	Console.WriteLine($"Введите { whatWePrompt }");

	curPrompt = int.Parse(Console.ReadLine());

	return curPrompt;
}

void PrintNaturalNumbers( int n )
{
	if ( n < 1 )
	{
		Console.WriteLine();
	}
	else
	{
		Console.Write( n + " " );
		PrintNaturalNumbers( --n );
	}
}

int N = Prompt();
PrintNaturalNumbers( N );