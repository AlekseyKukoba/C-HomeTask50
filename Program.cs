// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Getnum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

Console.Clear();

int row = Getnum(" Введите количество строк: ");
int column = Getnum("Введите количество столбцов: ");

int[,] matrix = GetArray(row, column);

PrintArray(matrix);

int rowPosition = Getnum("Введите строчный индекс: ");
int columnPosition = Getnum("Введите количество столбцов: ");

if (rowPosition < 0 || columnPosition < 0)
{
    Console.WriteLine("Позиции в массиве не могут быть отрицательными!");
}
else
{
    if (rowPosition < row && columnPosition < column)
    {
        Console.WriteLine($"Искомый элемент: {matrix[rowPosition, columnPosition]}");
    }
    else{
        Console.WriteLine("Такого элемента не существует!");
    }
}