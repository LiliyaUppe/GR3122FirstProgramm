// #15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int inputDayOfWeek = 0;
string inputLine = string.Empty;
ReadData();
CalculateData();
PrintData();
//запрос числа у пользователя
void ReadData()
{
    Console.Write("Input number of day week: "); //коментарий ко вводу
    inputLine = Console.ReadLine() ?? ""; //вводим число
}

// // преобразование строкового представления числа в знаковое целое число
void CalculateData()
{
    inputDayOfWeek = int.Parse(inputLine);
}

// //вывод результата в консоль через тернарный оператор 
void PrintData()
{
    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("there's no exist");
    }
    else
    {
        Console.WriteLine((inputDayOfWeek == 6 || inputDayOfWeek == 7) ? "weekend" : "B-Day (working day)");
    }

}


