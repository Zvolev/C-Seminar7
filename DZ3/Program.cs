/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillRandomMatrix(int line, int column, int argMin, int argMax) // наполняем матрицу случайными значениями по заданным параметрам и выводим на экран
{
    int[,] matrix = new int[line, column];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(argMin, argMax);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}



void AverageColumnMatrix(int[,] matr)
{ 
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        double average = sum / matr.GetLength(0);
        System.Console.Write($"{average :f2}\t");
    }
}

int line = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");
int min = Prompt("Укажите диапазон значений матрицы: от >- ");
int max = Prompt("до (включительно) >- ");

int[,] matrix = FillRandomMatrix(line, column, min, max + 1);
PrintMatrix(matrix);
AverageColumnMatrix(matrix);