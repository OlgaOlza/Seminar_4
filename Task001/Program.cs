﻿// Напишите программу, которая принимает на вход 
// число (А) и выдает сумму числе от 1 до (А)
// 7 -> 28
// 4 -> 10
// 8 -> 36


int GetInfo (string text)
{
Console.Write(text);
int inputNum = Convert.ToInt32 (Console.ReadLine());
return inputNum;
}

int numberA = GetInfo("Введите число A: ");
int sum = 0;
for (int i = 1; i <= numberA; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма всех чисел от 1 до {numberA} равна {sum}");