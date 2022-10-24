/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] FillRandomMatrix(int row, int column) // наполняем матрицу случайными значениями по заданным параметрам и выводим на экран
{
    double[,] matrix = new double[row, column];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() + rand.Next(-9, 9);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j] :f2}\t ");
        }
        System.Console.WriteLine();
    }
}

int row = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");

double[,] matrix = FillRandomMatrix(row, column);
PrintMatrix(matrix);
