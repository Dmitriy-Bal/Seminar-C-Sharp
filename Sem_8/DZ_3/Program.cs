/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
1 2 | 5 6
3 4 | 7 8
Результирующая матрица будет:
5  12
21 32
*/


void CreateArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 9);
    }
  }
}


void WriteArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] thirdMatrix)
{
  for (int i = 0; i < thirdMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < thirdMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum = firstMartrix[i,j] * secomdMartrix[i,j];
      }
      thirdMatrix[i,j] = sum;
    }
  }
}


Console.Clear();
Console.Write("Ведите размер матрицы через пробел: ");
string[] coord = Console.ReadLine().Split(" ");
int m = int.Parse(coord[0]);
int n = int.Parse(coord[1]);
int[,] matrix = new int[m, n];


int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[m, n];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] thirdMatrix = new int[m, n];

MultiplyMatrix(firstMartrix, secomdMartrix, thirdMatrix);
Console.WriteLine($"\nПроизведение элементов из первой и второй матриц:");
WriteArray(thirdMatrix);