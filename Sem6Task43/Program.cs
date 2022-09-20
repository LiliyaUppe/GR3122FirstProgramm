// # 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

// Метод считывания данных пользователя
(double slopeRatio1, double slopeRatio2, double coeff1, double coeff2) ReadData(string line1, string line2, string line3, string line4)
{
    // Выводим сообщение
    Console.Write(line1);
    double slopeRatio1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write(line2);
    double coeff1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write(line3);
    double slopeRatio2 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write(line4);
    double coeff2 = int.Parse(Console.ReadLine() ?? "0");
    return (slopeRatio1, slopeRatio2, coeff1, coeff2);
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//метод поиска точки пересечения двух прямых
double[] PointOfIntersection(double slopeRatio1, double slopeRatio2, double coeff1, double coeff2)
{
     double[] coordinate = new double[2];
    if (coeff1 == coeff2 && slopeRatio1 == slopeRatio2) Console.WriteLine("straight lines are coinciding");
    if (slopeRatio1 == slopeRatio2 && coeff1 != coeff2) Console.WriteLine("straight lines are parallel");
    else
    {
        double x = (coeff2 - coeff1) / (slopeRatio1 - slopeRatio2);
        double y = slopeRatio2 * x + coeff2;
        coordinate[0] = x;
        coordinate[1] = y;
    }
    return coordinate;
}

(double slopeRatio1, double coeff1, double slopeRatio2, double coeff2) askResult = ReadData("Input  slope ratio k1: ", "Input coeff b1: ", "Input slope ratio k2: ", "Input coeff b2: ");
double[] coordinate = PointOfIntersection(askResult.slopeRatio1, askResult.coeff1, askResult.slopeRatio2, askResult.coeff2);
PrintResult($"Point of intersection is ( {coordinate[0]}; {coordinate[1]} )");
