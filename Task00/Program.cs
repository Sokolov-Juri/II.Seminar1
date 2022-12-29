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
if(W == 1){Console.WriteLine("Понедельник");}
else if(W == 2){Console.WriteLine("Вторник");}
else if(W == 3){Console.WriteLine("Среда");}
else if(W == 4){Console.WriteLine("Четверг");}
else if(W == 5){Console.WriteLine("Пятница");}
else if(W == 6){Console.WriteLine("Суббота");}
else if(W == 7){Console.WriteLine("Воскресенье");}
else if(W < 1 || W > 7){Console.WriteLine("Номер дня недели не существует");}

///////////////////////////////////////////////////////////

Console.WriteLine("Введите Max number = ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i<=N)
{
    Console.Write($"{i}, ");
    i++;
}
Console.WriteLine("");
///////////////////////////////////////////////////////////

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if( a > b){Console.WriteLine($"Число a = {a} > числа b = {b}");}
else if(a == b){Console.WriteLine($"Число a = {a} = числу b = {b}");}
else {Console.WriteLine($"Число a = {a} != числу b = {b}");}

///////////////////////////////////////////////////////////////////
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число a = ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число b = ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число с = ");
int c = Convert.ToInt32(Console.ReadLine());

if( a > b && a > c){Console.WriteLine($"Число a = {a} максимальное");}
else if( b > a && b > c){Console.WriteLine($"Число b = {b} максимальное");}
else if( c > a && c > b){Console.WriteLine($"Число c = {c} максимальное");}

else if( a == b && a > c){Console.WriteLine($"Числа a = {a} и b = {b} максимальные");}
else if( b == c && b > a){Console.WriteLine($"Числа b = {b} и c = {c} максимальные");}
else if( a == c && a > b){Console.WriteLine($"Числа a = {a} и c = {c} максимальные");}

else if( a == c && a == b){Console.WriteLine($"Числа a = {a}, b = {b} и c = {c} равны");}

////////////////////////////////////////////////
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
//  (делится ли оно на два без остатка).
Console.WriteLine("Введите число a = ");
a = Convert.ToInt32(Console.ReadLine());
if( a % 2 == 0 ){Console.WriteLine($"Число a = {a} делится на 2 без остатка");}
else {Console.WriteLine($"Остаток от деления числа a = {a} на 2 равен {a%2}");}

////////////////////////////////////////////////
// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные
// числа от 1 до N
Console.WriteLine("Введите число N = ");
N = Convert.ToInt32(Console.ReadLine());
i = 1;
while(i <= N)
{
    if(i%2 == 0){
        Console.Write($"{i}, ");
    }
    i++;
}
