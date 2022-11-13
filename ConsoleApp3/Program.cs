/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void GetCubeNumbers(double numbers)
{
    double cube = 0;
    for (double i = 1; i <= numbers; i++)
    {
        cube = Math.Pow(i, 3);
        Console.WriteLine(cube);
    }

}

Console.WriteLine("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
GetCubeNumbers(x);

