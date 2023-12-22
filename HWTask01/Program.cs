// Необходимо найти большее из двух чисел.
// 1. Введем переменные первого и второго числа
// 2. Введем условие нахождения равных чисел (первоеЧисло == второеЧисло)
// 3. Выведем равные числа (Console.Write("С текстом")
// 4. Выведем условия нахождения большего числа (если первое больше второго, то отображаем первое, Но если первое меньше чем второе, то отображаем второе)
// 5. Отобразим получившийся результата


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
