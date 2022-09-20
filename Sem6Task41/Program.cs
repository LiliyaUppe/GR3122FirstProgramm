// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.



// Метод считывания данных пользователя
string[] ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);  
    // Считываем число, проверяем на NULL 
    // и разбиваем строку на массив строк
    // в качестве аргумента принимает разделитель - ","
  string inputLine = Console.ReadLine() ?? "0";
  string[] array =  inputLine.Split(",");
    // Возвращаем значение
    return array;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// метод подсчета чисел больше 0
int Count(string[] array)
{
int result = 0; 
for (int i = 0; i< array.Length; i++)
{
if (int.Parse(array[i]) > 0) result++; // явное преобразование string[ ] array в int.Parse(array[i]) прям в условии
}
return result;
}

string[] array = ReadData ("Input numbers with tail");

PrintResult($"Digit of numbers > 0 is {Count(array)}");

