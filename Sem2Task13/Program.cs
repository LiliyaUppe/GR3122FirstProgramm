// #13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string inputNumberA = string.Empty;
char[] charArray = { };
ReadData();
CalculateData();
PrintData();

// запрос числа от пользователя
void ReadData()
{
    Console.Write("Input  number: ");
    inputNumberA = Console.ReadLine() ?? "";
}
// проверяем на "техзначность" число 
// и выводим 2-ю цифру из числа
void CalculateData()
{
    if (inputNumberA.Length >= 3)
    {
        charArray = inputNumberA.ToString().ToCharArray();
    }
}
// Выводим резулльтат
void PrintData()
{
    if (inputNumberA.Length >= 3)
    {
        Console.WriteLine(charArray[2]);
    }
    else
    {
        Console.WriteLine("There's no third digit symbol");
    }
}