// #16
//
//
//

// вариант 1

// // чтение данных из консоли
int ReadData(string line) //добавим переменную "string line" - это сделает метод более УНВЕРСАЛЬНЫМ, "int" даст число на выход
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); //создали внутри число; чтобы не было никаких желтых ошибок,
                                                       //  приписали проверку на null (??" "), но в кавычках написали 0, 
                                                    // так как по условию задания если пользователь ничего не введет, 
                                                    // 0 возвращает наш метод
                                                       
    return number; //возвращаем значение
}

// тест на квадрат
bool SqrTest(int firstNum, int secondNum) // проверка на квадрат->поэтому используем bool true/fals логический тип данных; чтобы провести сам тест вводим два числа в скобках (переменные)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// // вывод данных
void PrintData(int firstNum, int secondNum) //передаем внутрь метода print два числа "int firstNum", "int secondNum"
{
    if (SqrTest(firstNum, secondNum)) //оставили условный оператор и применяем к нему "SqrTest"
    {
        // Console.WriteLine("Число "  +firstNum  + " квадрат числа " + secondNum);
        Console.WriteLine($"Число {firstNum} квадрат числа  {secondNum}");
    }
    else
    {
        // Console.WriteLine("Число " +firstNum +  " не квадрат числа " + secondNum);
        Console.WriteLine($"Число {firstNum} не квадрат числа  {secondNum}");
    }
}


int num1 = ReadData("input first number: "); //вызываем первое и второе числа
int num2 = ReadData("input second number: ");

PrintData(num1, num2); // сразу будем печатать результат, но сначала передадим первое число  в качестве квадрата (предполагаем, еще не знаем точно), а метод сам определит и даст ответ верный
PrintData(num2, num1); // сразу будем печатать результат, но сначала передадим второе число (поменяли местами) в качестве квадрата (предполагаем, еще не знаем точно), а метод сам определит и даст ответ верный



