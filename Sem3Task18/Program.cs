// #18 Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

int ReadData(string line) //метод общения с пользователем
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); //создали внутри число; чтобы не было никаких желтых ошибок,
                                                       //  приписали проверку на null (??" "), но в кавычках написали 0, 
                                                       // так как по условию задания если пользователь ничего не введет, 
                                                       // 0 возвращает наш метод

    return number; //возвращаем значение
}
string quterBoardAsk(int numberQuarter) // метод вычисления 
{
    if (numberQuarter == 1)
        return "x>0 y>0";
    if (numberQuarter == 2)
        return "x<0 y>0";
    if (numberQuarter == 3)
        return "x<0 y<0";
    if (numberQuarter == 4)
        return "x>0 y<0";

    return "";
}
void PrintResult(string line) // метод вывода данных 
   {
    Console.WriteLine(line);
   }


int number = ReadData("input number of quarter: ");


string  result = quterBoardAsk(number);
PrintResult("point of quarter is:  " + result);
