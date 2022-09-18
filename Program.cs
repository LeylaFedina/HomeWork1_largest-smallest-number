/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Clear();
Console.WriteLine("Введите значение 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.Write(userNumber1);
    Console.WriteLine(" больше");
    Console.Write(userNumber2);
    Console.WriteLine(" меньше");
}пше
else
{
    Console.Write(userNumber2);
    Console.WriteLine(" больше");
    Console.Write(userNumber1);
    Console.WriteLine(" меньше");
}