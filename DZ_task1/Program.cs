//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = ; b = 7 -> max = 7, min = 5

Console.Write ("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if( a > b)
{
    Console.WriteLine($"max = {a}");
    Console.WriteLine($"min = {b}");
}
else 
{
    Console.WriteLine($"max = {b}");
    Console.WriteLine($"max = {a}");
}