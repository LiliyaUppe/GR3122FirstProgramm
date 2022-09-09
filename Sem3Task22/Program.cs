// #22 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// //вариант 1
// //запрос данных у пользователя
// int ReadData(string line) 
// {
//     //выводим сообщение
//     Console.Write(line);
//     //считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0"); 
//     return number; //возвращаем значение
// }

// // формирование строки исходных чисел от 1 до N
// string LineNumber(int numberN) // "int numberN" - переменная которую мы передаем внутрь метода
// {
//     int i=1; // итератор который будет изменяться
//     string outLine = string.Empty; //переменная в которую аккумулируем ответ (по началу она пустая empty)
//     while (i < numberN) //сам цикл
//     {
//         outLine = outLine + i + " "; // в эту переменную добавляем старое значение этой перемнной (которое было до) + новое
//         ++i; // так как цикл идет на увеличение, 
//             // эта команда определит конец цикла, 
//             // то есть до каких пор прокручивать заданный цикл
//             // если не установить эту границу
//             // цикл будет бесконечно работать и чтобы остановить
//             // в противно случае комбинация ctr+C
//     }
//     outLine = outLine + numberN; // по завершению, чтобы последний разделитель " " не печатался
//     return outLine;
// }

// // расчет квадратов от 1 до N
// string LineSqer(int numberN)
// {
//   int i=1; 
//     string outLine = string.Empty; 
//     while (i<numberN) 
//     {
//         outLine = outLine + i*i + " "; 
//         ++i; 
//     }
//     outLine = outLine + numberN*numberN; 
//     return outLine;
// }

// //вывод результата
// void PrintResult(string line) // метод вывода данных 
//    {
//     Console.WriteLine(line);
//    }

// //собираем данные, то есть программируем свою программу
// int numberN = ReadData("input number N:"); //конанда считывания числа введенного пользователем
// string lineTop = LineNumber(numberN); //собираем заголовок таблицы
// string lineDown = LineSqer (numberN); //линия квадратов заданных чисел (низ таблицы)


// //выводим результат
// PrintResult (lineTop);
// PrintResult(lineDown);


//вариант 2 Универсальный код

//запрос данных у пользователя
int ReadData(string line) 
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number; //возвращаем значение
}

// формирование строки исходных чисел от 1 до N и расчет квадратов этих чисел
string LineNumber(int numberN, int pow) // метод стал универсальный относительно вар1(частный случай)
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

//собираем данные, то есть программируем свою программу
int numberN = ReadData("input number N:"); 

//выводим результат
PrintResult (LineNumber(numberN,1));
PrintResult(LineNumber(numberN,2));
