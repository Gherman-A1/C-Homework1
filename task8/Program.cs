﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите положительное число: ");
int N =int.Parse(Console.ReadLine()!);
int count=1;
while(count<=N)
{
    if (count%2==0) Console.WriteLine(+count);
    count ++;
}
 Console.WriteLine("Больше четных чисел нет");