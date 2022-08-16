// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j<array.GetLength(1)-1) Console.Write($"{array[i,j],3},");
            else Console.Write($"{array[i,j],3}");
        }
        Console.WriteLine();
    }
    
}

int GetUserInput()
{
    Console.WriteLine("Введите порядковый номер: ");
    return Convert.ToInt32(Console.ReadLine());
}

void SearchElement(int[,] array, int number)
{
    if(number>array.Length-1) Console.WriteLine($"{number} - такого числа в массиве нет");
    else
    {
        int i = number/array.GetLength(1);
        int j = number-(i*array.GetLength(1));
        Console.WriteLine($"{number} - {array[i,j]}");
    }
}

int[,] matrix = GetMatrix(3,4);
int seqNum = GetUserInput();
PrintMatrix(matrix);
SearchElement(matrix,seqNum);