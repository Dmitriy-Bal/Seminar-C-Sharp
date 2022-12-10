// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый вариант решения

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10000;
// int n2 = n / 1000 % 10;
// int n4 = n / 10 % 10;
// int n5 = n % 10;

// if (n1 == n5 && n2 == n4)
//     Console.Write("Это палиндромом");
// else
//     Console.Write("Это не палиндромом");


// Второй вариант решения

Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int newNumber = 0;
for (int i = n.Length - 1; i >= 0; i--)
{
    newNumber = newNumber + Convert.ToInt32(int.Parse(n[i].ToString()) * Math.Pow(10, i));
}
Console.WriteLine(newNumber);
if (newNumber == int.Parse(n))
    Console.WriteLine("Это палиндромом");
else 
    Console.WriteLine("Это не палиндромом");