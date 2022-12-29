// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// отрицательные числа не являются натуральными, но пусть для них тоже работает.
/*
void ShowNums(int num)
{
    Console.Write(num +" ");
    if(num > 1) ShowNums(num - 1);
    if(num < 1) ShowNums(num + 1);
}
ShowNums(-5);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNums(int numA, int numB)
{
    if(numA <= numB) return SumNums(numA + 1, numB) + numA;
    else
    // if(numA >= numB) return SumNums(numB + 1, numA) + numB; // этот кусок не работает почему-то (если первое число больше второго)
    // else
    return 0;
}

Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int sum = SumNums(numM, numN);
Console.WriteLine(sum);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int AckermannFunction (int m, int n)
{
    if (m == 0) return n+1;
    else
    if (m != 0 & n == 0) return AckermannFunction (m-1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int Ackermann = AckermannFunction(numM, numN);
Console.WriteLine(Ackermann);