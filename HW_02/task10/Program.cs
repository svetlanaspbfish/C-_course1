// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rand = new Random().Next(100,1000); // от 1 до 99
ShowSecondDigit( rand );

void ShowSecondDigit( int n )
{
	Console.WriteLine("На вход получено число " + n);
	int res = n / 10;
	res = res % 10;
	Console.WriteLine("Вторая цифра числа: " + res);
}