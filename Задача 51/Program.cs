﻿// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4 Сумма элементов главной диагонали: 1+9+2 = 12


int[,] nums = new int[3, 4];
int sum = 0;
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

int length = 0;
if (nums.GetLength(0) > nums.GetLength(1))
{
    length = nums.GetLength(1);
}
else
{
    length = nums.GetLength(0);
}

for (int i = 0; i < length; i++)
{
    sum += nums[i, i];
}

Console.WriteLine(sum);