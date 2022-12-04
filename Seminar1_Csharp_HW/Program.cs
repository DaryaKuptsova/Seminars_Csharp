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
