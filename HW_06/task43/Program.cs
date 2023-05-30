// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt( string whatWePrompt )
{
	int curPrompt;

	Console.WriteLine($"Введите { whatWePrompt }");

	curPrompt = int.Parse(Console.ReadLine());

	return curPrompt;
}

double k1 = Prompt("k1");
double b1 = Prompt("b1");
double k2 = Prompt("k2");
double b2 = Prompt("b2");

double x,y;

if ( k1 == k2 )
{
	Console.WriteLine("Прямые параллельны");
}
else
{
	x = ( b2 - b1 ) / ( k1 - k2 );
	y = k1 * x + b1;
	Console.WriteLine($"Координаты точки пересечения ({ x }; { y })");
}


