// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*

Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.Write("max = min = " + num1);
}
else
{
    if(num1 > num2)
    {
        Console.Write("max = " + num1 + "; " + "min = " + num2);
    }
else
    {
        Console.Write("max = " + num2 + "; " + "min = " + num1);
    }
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num2 > num1)
{
    if (num3 > num2)
    {
        Console.Write("max = " + num3);
    }
    else
    {
        Console.Write("max = " + num2);
    }
}
else
{
    if (num3 > num1)
    {
        Console.Write("max = " + num3);
    }
    else
    {
        Console.Write("max = " + num1);
    }
}

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input a number = ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Число является чётным.");
}
else
{
    Console.Write("Число является нечётным.");
}



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= num)
{
    Console.Write(current + ", ");
    current = current + 2;
}
переименовала папку 04.12.2022*/

// Вариант решения задач первого ДЗ через МЕТОД.
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int Find(int a, int b)
{
    int max;
    if (a > b)
        max = a;
    else
        max = b;
    return max;
}
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Max = Find(num1, num2);
Console.WriteLine("Большее число: " + Max);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int FindMax(int a, int b, int c)
{
    int max;
    if (b > a)
        if (c > b)
            max = c;
        else
            max = b;
    else
        if (c > a)
            max = c;
        else
            max = a;
    return max;
}
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max = FindMax(num1, num2, num3);
Console.WriteLine("Мксимальное число: " + Max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

bool Even(int a)
{
    if (a % 2 == 0)
        return true;
    else
        return false;
}
Console.WriteLine("Input a number = ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Even(num);
Console.WriteLine(result);

*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

void Even(int a)
{
    int current = 2;
    while (current <= a)
    {
        Console.Write(current);
        if (current == a) Console.Write(".");
        else
            Console.Write(", ");
        current = current + 2;
    }
}
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Even(num);

//тут нужно использовать void (и writeline)
