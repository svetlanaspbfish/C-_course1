// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int PromptF( string whatWeFillText = "Введите число" )
{
	Console.WriteLine( whatWeFillText );

	int n = int.Parse( Console.ReadLine() );

	return n;
}

int a = PromptF();
int res = 0;

while ( a > 0 )
{
	res += a % 10;
	a = a/10;
}

Console.WriteLine( res );