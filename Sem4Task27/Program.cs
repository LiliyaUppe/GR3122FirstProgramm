// #27 Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//сумма цифр в числе
int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number%10; //sum = sum+number%10
        number = number / 10;
    }
    return sum;
}


int number = ReadData("Input number: ");
int result = SumOfDigits(number);
PrintResult("Sum of digits is " + result);