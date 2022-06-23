/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string firstnumber = Console.ReadLine();
int number_1= int.Parse(firstnumber);
Console.WriteLine("Введите второе число");
string secondnumber = Console.ReadLine();
int number_2= int.Parse(secondnumber);

if (number_1 > number_2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (number_1 < number_2)
{
    Console.WriteLine("Первое число меньше второго");
}
else 
    {
        Console.WriteLine("Чиcла равны");
    }