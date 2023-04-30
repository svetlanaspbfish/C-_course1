// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = PromptF("Введите координату X первой точки:"),
	y1 = PromptF("Введите координату Y первой точки:"),
	z1 = PromptF("Введите координату Z первой точки:"),
	x2 = PromptF("Введите координату X второй точки:"),
	y2 = PromptF("Введите координату Y второй точки:"),
	z2 = PromptF("Введите координату Z второй точки:");

Console.WriteLine("Расстояние между точками: " + GetDistanse( x1, y1, z1, x2, y2, z2 ) );

int PromptF( string whatWeFillText )
{
	Console.WriteLine( whatWeFillText );

	int n = int.Parse( Console.ReadLine() );

	return n;
}

double GetDistanse( int x1, int y1, int z1, int x2, int y2, int z2 )
{
	double res = Math.Sqrt( Math.Pow( x2 - x1, 2 ) + Math.Pow( y2 - y1, 2 ) + Math.Pow( z2 - z1, 2 ) );
	return Math.Round( res, 2 );
}