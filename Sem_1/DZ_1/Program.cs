// Домашнее задание Семинара 1

// Задача 2: Напишите программу, которая 
// на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > n)
   Console.Write($"2-ое число больше: {m}");
else
   Console.Write($"1-ое число больше: {n}");
