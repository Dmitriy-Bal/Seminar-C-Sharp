/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100);
// }


// void ReleaseArray(int[] array)
// {
//     int max = array [0];
//     int min = array [0];
//     for (int i =0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
            
//         else if(array[i] < min)
//         {
//             min = array[i];
//         }    
//     }  
//     Console.WriteLine($"Минимальное число: {min}");
//     Console.WriteLine($"Максимальное число: {max}");
//     Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array); 
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);

//   2-й вариант решения

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}


void DiffMaxMin(double[] array)
{
    double minArray = array[0], maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minArray)
            minArray = array[i];
        else if (array[i] > maxArray)
            maxArray = array[i];
    }
    Console.WriteLine($"Минимальное число: {minArray}");
    Console.WriteLine($"Максимальное число: {maxArray}");
    Console.WriteLine($"Результат: {maxArray - minArray}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
DiffMaxMin(array);