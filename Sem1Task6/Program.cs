﻿////============================================================================================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет
//============================================================================================================
string? inputLine = Console.ReadLine ();
if (inputLine != null)
{
     int inputNumber = int.Parse(inputLine);
     if(inputNumber % 2 == 0)
    {
        Console.WriteLine("Четное число");
    }
    else
    {
        Console.WriteLine("Нечетное число");
    }
}
