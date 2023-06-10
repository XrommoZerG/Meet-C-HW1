// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение

int[] mass = new int[3];

string? strnumber;


for (int i = 0; i < 3; i++)
{
    switch (i)
    {
        case 0:
        Console.WriteLine("Введите первое число: ");
        break;
        case 1:
        Console.WriteLine("Введите второе число: ");
        break;
        case 2:
        Console.WriteLine("Введите третье число: ");
        break;
    }
     strnumber = Console.ReadLine();
     mass[i] = Convert.ToInt32(strnumber);

    
}

int max = mass[0];


for (int i = 0; i < mass.Length ; i++)
{
    if (max < mass[i])
    {
        max = mass[i];
    }
    
}

Console.WriteLine("Свмое большое число - " + max);

// // Проверка масива
// for (int i = 0; i < mass.Length ; i++)
// {
//             Console.WriteLine(mass[i]);

// }



