// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CheckElement(int[,] massive, int rowNumber, int columnNumber)
{
    if(rowNumber > massive.GetLength(0) + 1 | columnNumber > massive.GetLength(1) +1)
    {
        Console.WriteLine("такого элемента в массиве нет");
    }
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            if(i == rowNumber - 1 & j == columnNumber - 1) Console.WriteLine(massive[i, j]);
        }
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

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите номер строки массива: ");
int n = GetInput("Введите номер столбца массива: ");

int[,] matrix = Create2DMassive();
Print2DMassive(matrix);
Console.Write($"{m},{n} -> ");
CheckElement(matrix, m, n);