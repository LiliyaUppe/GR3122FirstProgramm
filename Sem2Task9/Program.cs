// #9 Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.


// ВАРИАНТ 1

// System.Random numberGenerator = new System.Random(); // создаем экземпляр класса - из которого ("черного ящика") нужно выбрать СЛУЧАЙНОЕ число
// // numberGenerator - переменная
// // new System.Random() - объем памяти для генератора 
// // тип переменной указываем перед переменной - System.Random, так как это переменная СТРОГОЙ типизации. 
// // тип будет такой же как название класса - System.Random
// // "тип переменной" совпадает с "классом переменной"


// int number = numberGenerator.Next(10, 100); // далее получаем число: необходимо обратиться к генератору и выбрать доступный метод  

// Console.WriteLine(number);// выводим то число которое выбериться случайным образом генератором

// // далее выбираем два числа из которых программа выберет наибольшее

// int firstDigit = number / 10; //  задаем переменную firstDigit, которая делиться на 10, переменная старшего разряда
// int secondDigit = number % 10;   // задаем переменную secondDigit, переменная младшего разряда

// if (firstDigit > secondDigit) // сравниваем эти два числа firstDigi ? secondDigit
// {
//     Console.WriteLine(firstDigit);
// }
// else
// {
//     Console.WriteLine(secondDigit);
// }

// ВАРИАНТ 2 через термальный оператор

// System.Random numberGenerator = new System.Random(); 

// int number = numberGenerator.Next(10, 100); 
// Console.WriteLine(number);

// int firstDigit = number / 10; 
// int secondDigit = number % 10;   

// Console.WriteLine((firstDigit > secondDigit)? firstDigit: secondDigit);

// ВАРИАНТ 3 через char оператор

System.Random numberGenerator = new System.Random(); 

int number = numberGenerator.Next(10, 100); 
Console.WriteLine(number);

char[] charArray = number.ToString().ToCharArray();

Console.WriteLine(((int)charArray[0] > (int)charArray[1])? charArray[0]: charArray[1]);
