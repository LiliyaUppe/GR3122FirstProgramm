// Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа. Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Method_1()
{
    Console.WriteLine("Method_1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(99, 1000);
    Console.WriteLine(number);
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    number = firstDigit * 10 + thirdDigit;
    Console.WriteLine(number);
}

void Method_2()
{
    Console.WriteLine("Method_2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(99, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToArray(); //превращение чисел в массив символов
    Console.WriteLine(charArray[0]);
    Console.WriteLine(charArray[2]);
}

void Method_3()
{
    Console.WriteLine("Method_3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(99, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToArray(); //превращение чисел в массив символов

    Console.WriteLine("" + charArray[0] + charArray[2]);
}


Method_1();
Method_2();
Method_3();




