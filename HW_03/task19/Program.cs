// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int n = PromptF();

if ( isPolindrom( n ) )
{
	Console.WriteLine("Число является полиндромом.");
}
else
{
	Console.WriteLine("Число не является полиндромом.");
}



int PromptF()
{
	Console.WriteLine("Введите пятизначное число");

	int n = int.Parse( Console.ReadLine() );

	while ( PromptHasErrors( n ) )
	{
		Console.WriteLine("Ошибка ввода. Введите пятизначное число");
		n = Math.Abs( int.Parse( Console.ReadLine() ) );
	}

	return n;
	
}

bool PromptHasErrors( int n )
{
	if ( n <= 10000 || n >= 100000 )
	{
		return true;
	}

	return false;
}

bool isPolindrom( int n )
{
	bool res = true;
	int firstDigit = n / 10000,
		lastDigit = n % 10;
	int secondDigit = n / 1000 - 10 * firstDigit,
		fourthDigit = ( n % 100 ) / 10 ;

	if ( firstDigit != lastDigit || secondDigit != fourthDigit ) 
	{
		res = false;
	}

	return res;
}