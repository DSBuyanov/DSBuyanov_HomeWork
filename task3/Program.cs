﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int d = int.Parse(Console.ReadLine());

  if (d == 6 || d == 7) {
  Console.WriteLine("да");
  }
  else if (d < 1 || d > 7) {
    Console.WriteLine("не является днем недели");
  }
  else Console.WriteLine("нет");
