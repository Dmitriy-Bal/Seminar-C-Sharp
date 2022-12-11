// Задача 1220: 

/*
Дана последовательность из N целых чисел и число K.
Необходимо сдвинуть всю последовательность
(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево,
если отрицательное.
Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N,
во второй строке записаны N целых чисел Ai,
а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
*/

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n];

for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 11);
Console.WriteLine($"[{string.Join(", ", array)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = array[array.Length - k + i];
    for (int i = 0; i < array.Length - k; i++)
        result[k + i] = array[i];
    Console.WriteLine($"[{string.Join(", ", result)}]");
}
else
{
    k = -k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = array[i];
    for (int i = 0; i < array.Length - k; i++)
        result[i] = array[k + i];
    Console.WriteLine($"[{string.Join(", ", result)}]");
}