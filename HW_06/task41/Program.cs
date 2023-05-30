// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int m = 5;
int res = 0;

int Prompt( int n )
{
	int countPositive = 0;
	int curPrompt;

	Console.WriteLine($"Введите { n } чисел");

	for (int i = 0; i < n; i++)
	{
		curPrompt = int.Parse(Console.ReadLine());
		if ( curPrompt > 0 ) countPositive++;
	}

	return countPositive;
}

res = Prompt( m );

Console.WriteLine($"Пользователь ввёл { res } положительных чисел.");
