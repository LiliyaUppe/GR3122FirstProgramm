// #21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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
double calcData(int x1, int y1, int z1, int x2, int y2, int z2)  
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
}

//вывод результата
void PrintResult(string line) // метод вывода данных 
   {
    Console.WriteLine(line);
   }

//собираем данные
int x1 = ReadData("input x1: ");
int y1 = ReadData("input y1: ");
int z1 = ReadData("input z1: ");
int x2 = ReadData("input x2: ");
int y2 = ReadData("input y2: ");
int z2 = ReadData("input z2: ");
//выводим результат
PrintResult(" d = " + Math.Round(calcData(x1, y1, z1, x2, y2, z2),2).ToString());

