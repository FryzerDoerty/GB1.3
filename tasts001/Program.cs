﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
string N = Console.ReadLine()!;
if (N[0] == N[4] && N[1] == N[3])
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

