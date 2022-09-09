// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


//запрос данных у пользователя
int ReadData(string line) 
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number; //возвращаем значение
}

// расчет расстояния между координатами точек
double calcData(int x1, int y1, int x2, int y2)  
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
}

//вывод результата
void PrintResult(string line) // метод вывода данных 
   {
    Console.WriteLine(line);
   }

//собираем данные
int x1 = ReadData("input x1: ");
int y1 = ReadData("input y1: ");
int x2 = ReadData("input x2: ");
int y2 = ReadData("input y2: ");

//выводим результат
PrintResult(" d = " + Math.Round(calcData(x1, y1, x2, y2),2).ToString());

