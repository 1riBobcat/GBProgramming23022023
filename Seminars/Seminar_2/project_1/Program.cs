﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Write three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(a);
Console.WriteLine("the second digit of this number -> "+s[1]);