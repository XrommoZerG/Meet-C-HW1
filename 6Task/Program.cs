// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Решение

Console.WriteLine("Введите число: ");
string? strNumber = Console.ReadLine();

int intnumber = Convert.ToInt32(strNumber);

if (intnumber % 2 == 0)
{
    Console.WriteLine("Чисто являеться чётным");

}
else{
    Console.WriteLine("Чисто являеться НЕ! чётным");

}


