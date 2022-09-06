// #14 Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

// Вариант 1
Console.WriteLine("Введите число: ");
string inputLineA = Console.ReadLine()??"";
int inputNumberA = int.Parse(inputLineA);
//  if (inputLineA != null)

    if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
    {
        Console.Write("Число кратно и 7, и 23");
    }
    else
    {
        Console.Write("Число не кратно  ни 7, ни 23");
    }

// вариант 2

// int number, resultA, resultB;

// // запрос числа у пользователя
// // и принимает текст запроса и команду выхода
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     // цикл выполняется до введения целого числа или "q"
//     while (true)
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();
// // игнорируем любое нажатие
//         if (inputLine == null)
//         {
//             continue;
//         }
//         // выходим из программы
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         // выдаем полученное число
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }

// // чтение данных из консоли
// void ReadData()
// {
//     number = RequestNumber("Enter number");
// }

// // определяем кратность чисел
// void CalculateData()
// {
// resultA = number % 7;
// resultB = number % 23;
// }

// // вывод данных
// void PrintData()
// {
// if(inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
// {
//  Console.Write("Число кратно и 7, и 23");
// }
// else
//     {
//         Console.Write("Число не кратно  ни 7, ни 23");
//     }
// }



// RequestNumber();
// ReadData();
// CalculateData();
// PrintData();


