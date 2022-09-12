// #24 Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberA = int.Parse(Console.ReadLine() ?? "0");
    return numberA; //возвращаем значение
}

//  вывод данных 
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// метод вычисления суммы от 1 до А
int VariantSumSimple(int numberA)
{
    int sumOfNumbers = 0; //числовая локальная переменная, в которой будет накапливаться результат
    for (int i = 1; i < numberA; i++) // цэто цикл в котором счетчик суммирует результат
    // for (int i = 1; i <= numberA; i++)
    {
        sumOfNumbers += i; //счетчик накрпитель суммы чисел от 1 до А
    }
    return sumOfNumbers + numberA; //вернет=выведет на экран сумму переменных
    // return sumOfNumbers;
}
//метод Гауса
int VariantSumGause(int numberA) //внутри скобок указывается или передается значение переменной чтобы ее использовать в методе
{
    int sumOfNumbers = 0; //изначально заказали long, консоль ругиется, тк на return требуется тип int указанный в методе -> меняем на int
    sumOfNumbers = ((1 + numberA) * numberA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("input number A: ");
int result1 = VariantSumSimple(numberA); //вернуть из метода- компелятор из метода выведет результат вычислений, то есть положит результат в переменную из метода
int result2 = VariantSumGause(numberA);
PrintResult("Sum of numbers 1...A (Simple method) = " + result1);
PrintResult("Sum of numbers 1...A (Gause's method) = " + result2);