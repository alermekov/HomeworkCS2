// Задача 1. Программа, принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
void SecondDigit(int num)
{
    num = (num / 10);
    num = (num % 10);
Console.WriteLine("Second digit is " + num);
}
Console.Write("Input three digits integer ");
int num = Convert.ToInt32(Console.ReadLine());
SecondDigit(num);
*/

//Задача 2. Программа, выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void ThirdDigit(int num)
{
    if (num < 100)
    Console.WriteLine("There is no third digit");
    else
        {
        string str = num.ToString();
        Console.WriteLine("Third number is: " + str[2]);
        }
}
Console.Write("Input integer ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit(num);
*/

// Задача 3. Программа принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
/*
void WeekendChecker(int day)
{
    if (day > 7 || day < 1)
    Console.WriteLine("Incorrect number of day!");
    else
    {
        if (day >= 6)
        Console.WriteLine ("It's weekend day))");
        if (day < 6)
        Console.WriteLine ("It's a long work day((");
    }
}
Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());
WeekendChecker(day);
*/
