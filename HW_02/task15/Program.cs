// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");

int n = int.Parse( Console.ReadLine() );

if ( n < 1 || n > 7 )
{
	Console.WriteLine("Некорректный ввод.");
}
else
{
	if ( isWeekend( n ) )
	{
		Console.WriteLine("Выходной.");
	}
	else
	{
		Console.WriteLine("Не выходной.");
	}
}

bool isWeekend( int n )
{
	if ( n == 7 || n == 6 )
	{
		return true;
	}
	else
	{
		return false;
	}
}