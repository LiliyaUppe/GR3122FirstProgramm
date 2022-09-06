// #10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

string inputNumberA = string.Empty;
char[] charArray = { };
ReadData();
CalculateData();
PrintData();

// запрос числа от пользователя
void ReadData()
{
    Console.Write("Input three-digit number: ");
    inputNumberA = Console.ReadLine() ?? "";
}
// проверяем на "техзначность" число 
// и выводим 2-ю цифру из числа
void CalculateData()
{
    if (inputNumberA.Length == 3)
    {
        charArray = inputNumberA.ToString().ToCharArray();
    }
}
// Выводим резулльтат
void PrintData()
{
    if (inputNumberA.Length == 3)
    {
        Console.WriteLine(charArray[1]);
    }
    else
    {
        Console.WriteLine("number isn't three-digit");
    }
}