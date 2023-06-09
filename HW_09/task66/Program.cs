// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt( string whatWePrompt = "число" )
{
	int curPrompt;

	Console.WriteLine($"Введите { whatWePrompt }");

	curPrompt = int.Parse(Console.ReadLine());

	return curPrompt;
}

int FindSumBenweenTwoNumbers( int m = 0, int n = 0 )
{
	if ( m <= 0) m = 1;
	if ( m == n ) 
	{
		return m;
	}
	else
	{
		return m + FindSumBenweenTwoNumbers( ++m, n );
	}

}

int M = Prompt();
int N = Prompt();

// Технически, натуральных чисел между м и н не будет, если н меньше 0.
// Если же м меньше нуля, а н больше нуля, то будут числа от 1 до н являться суммой всех натуральных чисел между м и н.
if ( M > N || M == N || N <= 0 )
{
	Console.WriteLine("Между M и N нет предполагаемого задачей промежутка натуральных чисел.");
}
else
{
	Console.WriteLine( FindSumBenweenTwoNumbers( M, N ) );
}



