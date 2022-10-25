/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/

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

void CheckSearchElementMatrix(int[,] matr, int y, int x)
{
    if (y < matr.GetLength(0) && x < matr.GetLength(1))
    {
        System.Console.Write($"Искомое значение => {matr[x, y]}");
    }
    else System.Console.WriteLine("Такого элемента нет!");
}

int line = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");
int min = Prompt("Укажите диапазон значений матрицы: от >- ");
int max = Prompt("до (включительно) >- ");
int[,] matrix = FillRandomMatrix(line, column, min, max + 1);
PrintMatrix(matrix);

int y = Prompt("Позиция искомого элемента в строке (нумерация начинается с 0) >- ");
int x = Prompt("и в столбце >- ");
CheckSearchElementMatrix(matrix, y, x);
System.Console.WriteLine();
