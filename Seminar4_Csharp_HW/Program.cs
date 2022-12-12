// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree (int A, int B)
{
    int result = 1;
    if (B <= 0) result = 0;
    for (int count = 1; count <= B; count++)
        result = result * A;
    return result;
}
Console.WriteLine("Input an integer number = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree of a number = ");
int degree = Convert.ToInt32(Console.ReadLine());

int Result = Degree(number, degree);
Console.WriteLine(Result);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// использован цикл while (c for не догадалась, как сделать. не работает)
/*
int Sum (int num)
{
    int result = 0;
    num = Math.Abs(num);
    if (num/10 == 0) result = result + num * 10 / 10;
    while (num/10 != 0)
    {
        int newnum = num % 10;
        result = result + newnum;
        num = num / 10;
        if (num/10 == 0) result = result + num * 10 / 10;
    }
    return result;
}

Console.WriteLine("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Result = Sum(number);
Console.WriteLine(Result);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input element: {i+1}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
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

Console.WriteLine("Input a number of elements: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(number);
Showarray(myArray);