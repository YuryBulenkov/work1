﻿// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N.
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 2;
if(N > 1)
{
  while(i <= N)
  {
    Console.Write(i+ " " );
    i = i + 2;
  }
}


