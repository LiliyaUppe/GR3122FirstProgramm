// #17 Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

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
int quterTest(int x, int y) // метод вычисления - универсальный
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y< 0)
        return 3;
    if (x > 0 && y< 0)
        return 4;

        return -1;
}
void PrintResult(string line) // метод вывода данных - универсальный
{
    Console.WriteLine(line);
}

int x = ReadData("input x: ");
int y = ReadData("input y: ");

int result = quterTest(x, y);
PrintResult("number of quarter is:  " + result);
