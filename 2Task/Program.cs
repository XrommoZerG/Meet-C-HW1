// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



// Решение 


Console.WriteLine("Введите первое число: ");
string? strNumber1 = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? strNumber2 = Console.ReadLine();

int intnumber1 = Convert.ToInt32(strNumber1);
int intnumber2 = Convert.ToInt32(strNumber2);

int max;
int min;

if (intnumber1 >= intnumber2)
{
    max = intnumber1;
    min = intnumber2;
}
else {
    max = intnumber2;
    min = intnumber1;
}

if (intnumber1 == intnumber2)
{
    Console.WriteLine("Числа равны - " + max);

     Console.WriteLine(max + " = " + min);


    
}
else
{
 Console.WriteLine(max + "- Являеться максимальным числом");
 Console.WriteLine(min + "- Являеться минимальным числом");

 Console.WriteLine(max + " > " + min);


}



