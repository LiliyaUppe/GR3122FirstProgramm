// #25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Чтение данных из консоли
(int numberA, int numberB) ReadData(string line1, string line2)
{
    // Выводим сообщение
    Console.WriteLine(line1);
    int numberA = int.Parse(Console.ReadLine() ?? "0");  // Считываем число
    Console.WriteLine(line2);
    int numberB = int.Parse(Console.ReadLine() ?? "0");
    return (numberA, numberB); // возвращаем переменную
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// //вычисление возведения в степень (цикл)
long PowFor(int numberA, int numberB)
{
    long result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

// ////вычисление возведения в степень (без цикла)
long PowMath(int numberA, int numberB)
{
    long result = (long)Math.Pow(numberA, numberB);
    return result;
}


(int numberA, int numberB) askResult = ReadData("Input number A: ", "Input number B: ");
DateTime d1 = DateTime.Now;
long result1 = PowFor(askResult.numberA, askResult.numberB);
DateTime d2 = DateTime.Now;
long result2 = PowMath(askResult.numberA, askResult.numberB);
Console.WriteLine(DateTime.Now - d1);
Console.WriteLine(DateTime.Now - d2);
PrintResult($"A^B = {result1}" + " - cycle method");
PrintResult($"A^B = {result2}" + " - simple method");

//старый вариант для новичкой, простой
// int numberA = ReadData("Input number A: ");
// int numberB = ReadData("Input number B: ");
// DateTime d1 = DateTime.Now;
// long result2 = PowMath(numberA, numberB);
// Console.WriteLine(DateTime.Now-d1);
// PrintResult($"A^B = {result2}" + " - simple method");
