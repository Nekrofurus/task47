﻿// Задайте двумерный массив размером m x n заполненный случайными вещественными числами
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int maximum = UserInput("Введите максимальное значение = ");
int minimum = UserInput("Введите минимальное значение = ");
double[,] CreateRandomDoubleMatrix(int line, int columb, int min, int max)
{
    double[,] matrix = new double[line,columb];
    for (int i = 0; i < line; i++)
    {
        Random random = new Random();
        for (int j = 0; j < columb; j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * (max - min) + min, 2);
        }
    }
    return matrix;
}
int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[,] createRandomDoubleMatrix = CreateRandomDoubleMatrix(numberLine, numberColumb, minimum, maximum);
void PrintArrayMatrix(double[,] matrix, int line, int columb)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }   
}
PrintArrayMatrix(createRandomDoubleMatrix, numberLine, numberColumb);