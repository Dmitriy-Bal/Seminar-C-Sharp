// Задача 13:

/*
Напишите программу,
которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
(НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)
645 -> 5
78 -> третьей цифры нет
326791 -> 6
*/


int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int n, int m)
{
int result = 0;
    if (m < 3)
    {
        Console.Write("Третьей цифры нет: ");
    }
    else
    {
        int c = 1;
        for (int i = m; i > 3; i--)
        {
            c = c * 10;
        }
        result = (n / c) % 10;
    }
return result;
}