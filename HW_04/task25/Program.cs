// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int PromptF( string whatWeFillText = "Введите число" )
{
	Console.WriteLine( whatWeFillText );

	int n = int.Parse( Console.ReadLine() );

	return n;
}


int a = PromptF();
int b = PromptF("Введите натуральное число");
int res = a;

while ( b <= 0 )
{
	b = PromptF("Введите натуральное число");
}

// Я не знаю, можно ли так в си шарпе :)) Сча узнаю. Можно.
for (int i = 1; i < b; i++, res *= a ) {}

Console.WriteLine( res );