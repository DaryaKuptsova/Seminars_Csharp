// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Добавить проверку на то, трехзначное число или нет внутрь метода тоже получилось (по типу второй задачи), но избавиться от неверного вывода второй цифры при этом не вышло. Поэтому отсавляю проверку вне метода.

int SecondDigit(int Num)
{
    int second = Num / 10 % 10;
    return second;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999 || num < 100)
    Console.WriteLine("Вы ввели не трехзначное число!");
else
    {
    int newnum = SecondDigit(num);
    Console.WriteLine("Вторая цифра этого числа: " + newnum);
    }


// Попытки добавить проверку таким образом, чтобы снова запускалось сообщение о необходимости ввода числа, не увенчались успехом.
// Ниже оставила свои варианты (это не одна программа, а несколько кусочков вариантов).
// if (a / 100 > 0 && a / 1000 == 0) - то число трехзначное

// int Check(int a)
// {
//     if (a > 999 || a < 100)
//         Console.WriteLine("Вы ввели не трехзначное число. Введите число из трех знаков");
//     return a;
// }
// int result = Check(num);
// Console.WriteLine(result);

// while (num < 1000 && num > 99)
// {
//     Console.WriteLine("Enter a three digit number: ");
//     num = Convert.ToInt32(Console.ReadLine());
//     int newnum = SecondDigit(num);
//     Console.WriteLine("Second number is: " + newnum);
// }
// Console.WriteLine("Вы ввели не трехзначное число. Введите число из трех знаков");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int Num)
{
    int result = -1;
    if (Num >= 100)
    {
        while (Num > 999)
        {
            Num = Num / 10;
        }
        result = Num % 10;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Figure = ThirdDigit(num);
Console.WriteLine(Figure);
*/

// код ниже не работает. пыталась впихнуть в одно условие (цикл)
// while(num / 1000 !=0)
//     num = num / 10;
// int third = num % 10;
// Console.WriteLine(third);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool CheckWeekDay (int a)
{
    if(a == 6 || a == 7)
        return true;
    else
        return false;
}

Console.WriteLine("Input a number of the week day: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = CheckWeekDay(num);
Console.WriteLine("День является выходным? - " + result);

// Решение без метода представляется мне более очевидным и красивым. Тогда можно консоль попросить написать однозначно - Деня является выходным или День не является выходным. 
// Как тут сделать красивее, я не догадалась.

*/