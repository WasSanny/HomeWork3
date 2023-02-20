﻿// Программа, которая на вход принимает координаты двух точек, и находит
// расстояние между точками в 3D пространстве: _Задача 21_

Console.WriteLine("Введите координаты точки (x1, y1, z1)");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки (x2, y2, z2)");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"Расстояние между точками по заданным координатам равно: {result}");