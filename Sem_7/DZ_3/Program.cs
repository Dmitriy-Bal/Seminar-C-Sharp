/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


void InputMatrix(int[, ] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] + " "} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}


Console.Write("Ведите размер матрицы через пробел: ");
string[] coord = Console.ReadLine().Split(" ");
int n = int.Parse(coord[0]);
int m = int.Parse(coord[1]);
double[, ] matrix = new double[n, m];

int[, ] numbers = new int[n, m];
ReleaseMatrix(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double k = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        k = (k + numbers[i, j]);
    }
    k = Math.Round(k / n, 3);
    Console.Write($"{k} \t");
}
Console.WriteLine();
InputMatrix(numbers);