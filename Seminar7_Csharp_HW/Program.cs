// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble(), 2);
            array[i, j] = array[i, j] + new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return array;
}

void Show2dArray (double[,] array) // в одну строку выводить двумерные нельзя
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue +1);
    }
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement (int[,] array)
{
    Console.Write("Input index i: ");
    int indexI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index j: ");
    int indexJ = Convert.ToInt32(Console.ReadLine());
    if (indexI < 0 | indexI > array.GetLength(0) - 1 | indexJ < 0 | indexJ > array.GetLength(1) - 1)
        Console.WriteLine("There is no elements with such indexes.");
    else
        Console.WriteLine ($"Element with indexes {indexI} and {indexJ} = {array[indexI, indexJ]}");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindElement(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue +1);
    }
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColumns (int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {            
            sum = sum + array[i, j];
        }
        average = sum / array.GetLength(0);
        double[] newArray = new double[array.GetLength(1)];
        int ind = 0;
        newArray[ind] = Math.Round(average, 1);
        Console.Write(newArray[ind] + "; ");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
AverageColumns(myArray);