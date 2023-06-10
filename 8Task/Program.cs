// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Решение


Console.WriteLine("Введите число больше 1: ");
string? strNumber = Console.ReadLine();

int intnumber = Convert.ToInt32(strNumber);

        Console.WriteLine("------------------------------------");

if (intnumber < 1)
{
    Console.WriteLine( intnumber + "  Это число явно меньше 1. Вернитесь к изучению чисел.");
    
}
else if (intnumber == 1)
{
    Console.WriteLine("И что прекажешь выводить от 1 до 1 ?");
}
else if (intnumber == 2)
{
    Console.WriteLine("Молодец ты вёл 2 но промежуто пуст, удачи , Умник.");

}
else
{
for (int i = 1; i < intnumber; i++)
{
    if (i % 2 ==0)
    {
        Console.WriteLine(i);
    }

}

}

