//Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите цифрой день недели: ");
string NumberDay = Console.ReadLine();

if(int.Parse(NumberDay) == 3)
{
    Console.WriteLine("среда");
}
else
{
    if(int.Parse(NumberDay) == 5)
    {
        Console.WriteLine("пятница");
    }
    else
    {
        if(int.Parse(NumberDay) == 1)
        {
            Console.WriteLine("понедельник");
        }
    }
    
// Console.WriteLine("не среда и не пятница");
}
