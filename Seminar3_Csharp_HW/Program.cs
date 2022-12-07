// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// корректно работает только для пятизначного числа
/*
void Palindrom (int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10 && number / 100 % 10 == number % 1000 / 100)
        Console.Write("Number is palindrom.");
    else
        Console.Write("Number is not palindrom");
}

Console.WriteLine("Input a 5 digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
    num = Math.Abs(num);
Palindrom (num);
*/
/*
// такое же решение, но с bool.
bool Palindrom (int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10 && number / 100 % 10 == number % 1000 / 100)
        return true;
    else
        return false;
}

Console.WriteLine("Input a 5 digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
    num = Math.Abs(num);
bool result = Palindrom(num);
Console.WriteLine(result);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xa, double xb, double ya, double yb, double za, double zb)
{
    double kv1 = Math.Pow((xb - xa),2);
    double kv2 = Math.Pow((yb - ya),2);
    double kv3 = Math.Pow((zb - za),2);
    double sqrt = Math.Sqrt(kv1 + kv2 + kv3);
    return sqrt;
}

Console.WriteLine("Input 1st A coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 2nd A coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 3d A coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 1st B coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 2nd B coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 3d B coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());

double result = Distance(xa, xb, ya, yb, za, zb);
Console.WriteLine(result);
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int number)
{
    int num = 1;
    while (num <= number)
    {
        Console.Write(Math.Pow(num,3));
        if (num == number) Console.Write(".");
        else
            Console.Write(", ");
        num++;
    }
}
Console.WriteLine("Input an integer number: ");
int result = Convert.ToInt32(Console.ReadLine());
Cube (result);

