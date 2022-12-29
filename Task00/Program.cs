// Все домашние задачи в конце

// See https://aka.ms/new-console-template for more information
Console.Write("Введите число для возведения в квадрат X = ");
int X = Convert.ToInt32(Console.ReadLine());
int square = X * X;
Console.WriteLine($"Квадрат введенного числа X = {X} равен X^2 = {square}");

////////////////////////////////////////////////

Console.WriteLine("Введите первое число X для проверки, что первое число - квадрат второго = ");
X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число Y для проверки, что первое число - квадрат второго = ");
int Y = Convert.ToInt32(Console.ReadLine());
square = Y * Y;

if (X == square)
{
    Console.WriteLine($"Первое введенное число X = {X} является квадратом второго X = Y ^ 2 = {square}");
}
else
{
    Console.WriteLine($"Первое введенное число X = {X} НЕ является квадратом второго X != Y ^ 2 = {square}");
}

//////////////////////////////////////////////////

Console.WriteLine("Введите номер дня недели W = ");
int W = Convert.ToInt32(Console.ReadLine());
if (W == 1) { Console.WriteLine("Понедельник"); }
else if (W == 2) { Console.WriteLine("Вторник"); }
else if (W == 3) { Console.WriteLine("Среда"); }
else if (W == 4) { Console.WriteLine("Четверг"); }
else if (W == 5) { Console.WriteLine("Пятница"); }
else if (W == 6) { Console.WriteLine("Суббота"); }
else if (W == 7) { Console.WriteLine("Воскресенье"); }
else if (W < 1 || W > 7) { Console.WriteLine("Номер дня недели не существует"); }

///////////////////////////////////////////////////////////

Console.WriteLine("Введите Max number = ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i <= N)
{
    Console.Write($"{i}, ");
    i++;
}
Console.WriteLine("");
///////////////////////////////////////////////////////////

