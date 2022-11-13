/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

GetPalindrome(num);

int GetPalindrome(int number)
{
    if (number > 99999 || number < 10000)
    {
        Console.WriteLine("Вы ввели не пятизначное число.");
    }
    else
    {
        int rem5 = number % 10;
        int num4 = (number - rem5) / 10;

        int rem4 = num4 % 10;
        int num3 = (num4 - rem4) / 10;

        int rem3 = num3 % 10;
        int num2 = (num3 - rem3) / 10;

        int rem2 = num2 % 10;
        int rem1 = (num2 - rem2) / 10;

        // Console.WriteLine($"{rem1}, {rem2}, {num2}, {rem3}, {num3}, {rem4}, {num4}, {rem5}");

        if (rem5 == rem1 && rem4 == rem2)
        {
            Console.WriteLine("Это число - палиндром.");
        }
        else Console.WriteLine("Это число - не палиндром.");
    }
    return number;
}
