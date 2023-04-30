// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");

int n = int.Parse( Console.ReadLine() );

ShowThirdDigit( n );

void ShowThirdDigit( int a )
{
	if ( a < 100 )
	{
		Console.WriteLine("Третьей цифры нет.");
	}
	else
	{
		while ( a > 999 )
		{
			a /= 10;
		}

		Console.WriteLine("Третья цифра: " + a % 10 );

	}
}