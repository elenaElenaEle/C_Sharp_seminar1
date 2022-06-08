// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2 3 7 -> 7

Console.Write ("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write ("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    } 
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}
Console.Write($"max = {max}");