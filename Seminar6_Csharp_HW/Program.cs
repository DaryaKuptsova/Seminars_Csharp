// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountPositive(int quantity)
{
   int num = 0;
   int nextNum = 0;
   int count = 0;
   while(quantity > 0)
   {
     Console.WriteLine($"Input the {nextNum +1} number:");
     num = Convert.ToInt32(Console.ReadLine());
     nextNum = nextNum + 1;
     quantity = quantity - 1;
     if(num > 0)
       count++;
   }
   return count;
}

Console.WriteLine("Input a quantity of numbers: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int result = CountPositive(quantity);
Console.WriteLine($"Quantity of positive numbers: {result}");
*/
// Задача 2 ( Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем)

void IntersectionPoint (double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 != b2)
        Console.WriteLine("These lines do not intersect.");
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("The lines match.");
    else
    {
        double x = 0;
        x = (b2 - b1) / (k1 - k2);
        double y = 0;
        y = k1 * x + b1;
        Console.WriteLine($"The intersection Point is ({x}, {y})");
    }
}

Console.WriteLine("Input k1 from y = k1 * x + b1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1 from y = k1 * x + b1: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2 from y = k2 * x + b2: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2 from y = k2 * x + b2: ");
double num4 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(num1, num2, num3, num4);
