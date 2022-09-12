// #26 Напишите программу, которая принимает на вход
// число и выдаёт колличество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5


//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number; //возвращаем значение
}

//  вывод данных 
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// метод вычисления колличества цифр в числе. массив
int NumberOfDigits(int number)
{
    char[] charArray = number.ToString().ToCharArray();
    return charArray.Length;
}
//  или вариант через string
// {
//     string numberString = numberString.ToString();
//     return numberString.Length;
// }

int number = ReadData("input number A: ");
int result = NumberOfDigits(number);
PrintResult("Number of digits = " + result);

//количество цифр в числе. цикл
// int NumberOfDigits(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += 1;
//         num = num / 10;
//     }
//     return sum;
// }

// //количество цифр в числе. логорифм
// int NumberOfDigitsLog(int num)
// {
//     return (int)(Math.Log10(num) + 1);
// }

// int number = ReadData("Input number: ");
// int result1 = NumberOfDigits(number);
// // int result2 = NumberOfDigitsLog(number);
// PrintResult("Sum of digits is" + result1);
// // PrintResult("Sum of digits is" + result2);