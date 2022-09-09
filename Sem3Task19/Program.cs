// #19 Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

// тест на пятизначность и полиндром
bool TestPolin(int numberP)
{
    if ((numberP > 9999) && (numberP < 100000))
    {
        if ((numberP / 10000) == (numberP % 10) && (numberP / 1000) % 10 == ((numberP / 10) % 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        Console.WriteLine("Try again!");
        return false;
    }
}

//вывод результата
void PrintData(int numberP)
{
    if (TestPolin(numberP))
    {
        Console.WriteLine("This's Polindrom. Well done!");
    }
    else
    {
        Console.WriteLine("This isn't Polindrom. Sorry!");
    }
     if ((numberP < 9999) && (numberP > 100000))
     {
         Console.WriteLine("Try again!");
    }
}

//собираем данные, то есть программируем свою программу
int numberP = ReadData("input five-digit number Polindrom: ");

PrintData(numberP);

