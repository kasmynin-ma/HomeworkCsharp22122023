// Найти максимальное из трех чисел
// 1. Задать на вход три числа a, b, c 
// 1. Найти максимальное число из двух чисел a и b
// 2. Сравнить полученное максимальное число с числом c
// 3. вывести максимальное полученное число

Console.Write("Введите первое число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число c:");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимально число: " + a);
    }
    else
    {
        Console.WriteLine("Максимально число: " + c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("Максимально число: " + b);
    }
    else
    {
        Console.WriteLine("Максимально число: " + c);
    }
}