﻿//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double [,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = Math.Round(rnd.NextDouble()*(rnd.Next(-10,100)),1);
            matrix[i,j] = num;
        }
    }
    return matrix;
}

void PrintMatrix (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j==0) Console.Write("[");
            if(j<array.GetLength(1)-1) Console.Write($"{array[i,j],5},");
            else Console.Write($"{array[i,j],5}]");
        }
        Console.WriteLine();
    }
    
}

double[,] matrix = GetMatrix(3,4);
PrintMatrix(matrix);