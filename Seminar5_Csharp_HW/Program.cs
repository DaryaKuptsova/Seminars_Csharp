// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(100, 1000); 
    return array;
}   

void Showarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[" + array[i] + ", ");
        else
        {
            if (i == array.Length - 1) Console.Write(array[i] + "]");
            else
                Console.Write(array[i] + ", ");
        }
    }
}

int EvenIntQuantity (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Array is: ");
Showarray(myArray);

int count = EvenIntQuantity(myArray);
Console.WriteLine();
Console.WriteLine("Quantity of even integers in array is: " + count);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1); 
    return array;
}   

void Showarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[" + array[i] + ", ");
        else
        {
            if (i == array.Length - 1) Console.Write(array[i] + "]");
            else
                Console.Write(array[i] + ", ");
        }
    }
}

int SumOfUneven (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sum = sum + array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Array is: ");
Showarray(myArray);

int sum = SumOfUneven(myArray);
Console.WriteLine();
Console.WriteLine("Sum of integers with uneven indexes is: " + sum);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2);
        array[i] = array[i] + new Random().Next(minValue, maxValue + 1);
    }
    return array;
}   

void Showarray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[" + array[i] + "; ");
        else
        {
            if (i == array.Length - 1) Console.Write(array[i] + "]");
            else
                Console.Write(array[i] + "; ");
        }
    }
}

double FindDiffMaxMin (double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else
            if (array[i] < min) min = array[i];
        difference = Math.Round(max - min, 2);
    }
    return difference;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Array is: ");
Showarray(myArray);

double result = FindDiffMaxMin(myArray);
Console.WriteLine();
Console.WriteLine("Differnce between max and min number = " + result);
