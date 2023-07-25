// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void CountColumnsMean(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < massive.GetLength(0); j++)
        {
            sum = sum + massive[j, i]; 
        }
        Console.Write($"{Math.Round((sum / massive.GetLength(0)), 2)}; ");
    }
}

void Print2DMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Create2DMassive()
{
    int rows = new Random().Next(1, 10);
    int columns = new Random().Next(1, 10);
    int[,] massive = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            massive[i, j] = new Random().Next(1, 100);
        }
    }
    return massive;
}

int[,] matrix = Create2DMassive();
Print2DMassive(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
CountColumnsMean(matrix);