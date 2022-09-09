// #23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



//запрос данных у пользователя
int ReadData(string line) 
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number; //возвращаем значение
}

// формирование строки исходных чисел от 1 до N и расчет кубов этих чисел
string LineNumber(int numberN, int pow) 
{
    int i=1; 
    string outLine = string.Empty; 
    while (i < numberN) 
    {
        outLine = outLine + Math.Pow(i,pow) + "\t"; 
        ++i;
    }
    outLine = outLine + Math.Pow(numberN,pow); 
    return outLine;
}

//вывод результата
void PrintResult(string line) // метод вывода данных 
   {
    Console.WriteLine(line);
   }

//собираем данные и программируем 
int numberN = ReadData("input number N:"); 

//выводим результат
PrintResult (LineNumber(numberN,1));
PrintResult(LineNumber(numberN,3));