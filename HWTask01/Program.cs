// Необходимо найти большее из двух чисел.
// 1. Введем переменные первого и второго числа
// 2. Введем условие нахождение большего числа
// 3. Отобразим получившийся результата


Console.Write("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber)
{
    Console.Write("Введенные числа равны" +" `" + firstNumber + "` ");
}
else
    if (firstNumber > secondNumber)
    {
        Console.Write("Первое число" +" `" + firstNumber + "` " + "больше чем второе число" + " `" + secondNumber + "` ");
    }
    else
    {
        Console.Write("Первое число" +" `" + firstNumber + "` " + "меньше чем второе число" + " `" + secondNumber + "` ");
    }   
