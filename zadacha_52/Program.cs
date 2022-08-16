// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] AverageColumns( int[,] array)
{
    double[] arrayAvCol = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumn = sumColumn + array[i,j];
        }
        arrayAvCol[j] = Math.Round((sumColumn/array.GetLength(0)),1);
    }
    return arrayAvCol;
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
void PrintResult (double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write(array[i]+"; ");
        else Console.Write(array[i]);
    }
}


int[,] matrix = GetMatrix(5,4);
PrintMatrix(matrix);
double[] averageColumns = AverageColumns(matrix);
PrintResult(averageColumns);