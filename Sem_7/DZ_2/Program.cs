/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет
*/

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }   
        Console.WriteLine(); 
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

Console.Write("Ведите размер матрицы через пробел: ");
string[] coord = Console.ReadLine().Split(" ");
int n = int.Parse(coord[0]);
int m = int.Parse(coord[1]);
double[, ] matrix = new double[n, m];
int [, ] numbers = new int [10,10];
ReleaseMatrix(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такой позиции в массиве нет");
}
else
{
    Console.WriteLine($"Значение {n}-го элемента строки и {m}-го столбца, равно: {numbers[n-1,m-1]}");
}

InputMatrix(numbers);