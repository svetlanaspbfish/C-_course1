// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt( string whatWePrompt = "число" )
{
	int curPrompt;

	Console.WriteLine($"Введите { whatWePrompt }");

	curPrompt = int.Parse(Console.ReadLine());

	return curPrompt;
}

int AkkermanFunc( int n = 0, int m = 0 )
{
	if ( n == 0 )
	{
		return m + 1;
	}
	else
	{
		if ( m == 0 )
		{
			return AkkermanFunc( n - 1, 1 );
		}

		return AkkermanFunc( n - 1, AkkermanFunc( n, m - 1 ) );
	}

}

int M = Prompt();
int N = Prompt();

if ( M < 0 || N < 0 )
{
	Console.WriteLine("Для работы программы нужны были два неотрицательных числа.");
}
else
{
	Console.WriteLine( AkkermanFunc( M,N ) );
}