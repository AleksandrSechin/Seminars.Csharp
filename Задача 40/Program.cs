﻿// Задача 40: Напишите программу, которая принимает на вход
//  три числа и проверяет, может ли существовать треугольник 
//  с сторонами такой длины.Теорема о неравенстве треугольника:
//   каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите первую сторону треуголька: ");
int ab = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треуголька: ");
int ac = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите третью сторону треуголька: ");
int bc = Int32.Parse(Console.ReadLine());
if (ab >= (ac + bc) || ac >= (bc + ab) || bc >= (ac + ab))
{
    Console.WriteLine("Треугольника с такими сторонами не существует");
}
else { Console.WriteLine("Такой треугольник может существовать"); }