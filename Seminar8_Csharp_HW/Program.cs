
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void Sorted2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)  
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int c = j + 1; c < array.GetLength(1); c++)
                if (array[i, j] < array[i, c])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, c];
                    array[i, c] = temp;
                }
        }
    }       
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Sorted2dArray(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows + 1;
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

int FindMinSumRowInd(int[,] newArray)
{
    int ind = 0;                                    
    int[] array = new int[newArray.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++) // находим сумму в каждой строке, преобразовывая в одномерный массив
    {
        int sum = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum += newArray[i, j];
        }
        array[ind] = sum;
        ind++;
    }
    int indMin = 0;   
    int min = array[indMin];
    for (int i = 0; i < array.Length; i++) // ищем минимальное значение в созданном ранее одномерном массиве
    {
        if (array[i] < min)
        {
            min = array[i];
            indMin = i;
        }
    }
    return indMin;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"Row with min sum number is: {FindMinSumRowInd(myArray) + 1}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] Create2dArray()
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

int [,] MatrixProduct (int[,] arrayFirst, int [,] arraySecond)
{
    int i = 0;
    int j = 0;
    int[,] newMatrix = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    newMatrix[i, j] = 0;
    if (arrayFirst.GetLength(1) == arraySecond.GetLength(0))
    {
        for (i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for (j = 0; j < arraySecond.GetLength(1); j++)
            {
                for (int a = 0; a < arraySecond.GetLength(1); a++)
                    {
                        newMatrix [i, j] = newMatrix [i, j] + (arrayFirst[i, a] * arraySecond[a, j]);
                    }
            }
            
        }
    }
    else Console.WriteLine("Matrices product can't be calculated. First matrix columns number is not equal to the second matrix rows number.");
    return newMatrix;
}

int[,] myFirstArray = Create2dArray();
int[,] mySecondArray = Create2dArray();
Show2dArray(myFirstArray);
Show2dArray(mySecondArray);
MatrixProduct(myFirstArray, mySecondArray);
int[,] matrixProduct = MatrixProduct(myFirstArray, mySecondArray);
Show2dArray(matrixProduct);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Create3dArray(int[,,] array3D)
{
  int[] newArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    newArray[i] = new Random().Next(10, 100);
    number = newArray[i];
    for (int j = 0; j < i; j++)
    {
    while (newArray[i] == newArray[j])
    {
        newArray[i] = new Random().Next(10, 100);
        j = 0;
        number = newArray[i];
    }
        number = newArray[i];
    }
  }
  int ind = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = newArray[ind];
        ind++;
      }
    }
  }
}

void Show3dArray(int[,,] array)
{
    for(int a = 0; a < array.GetLength(2); a++)
    { 
        for(int i = 0; i < array.GetLength(0); i++)             
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, a]} ({i},{j},{a}) ");
    
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of third dimensions: ");
int spaces = Convert.ToInt32(Console.ReadLine());
if (rows * columns * spaces <= 90)
{
    int[,,] array3D = new int[rows, columns, spaces];
    Create3dArray(array3D); 
    Show3dArray(array3D);
}
else
Console.WriteLine("There is no such number of non-repeating two-digit numbers. Input data = rows*columns*spaces < 90");