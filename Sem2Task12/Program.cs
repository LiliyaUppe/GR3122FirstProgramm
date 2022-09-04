// #12 Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным
// первому. Если второе число некратно
// первому, то программа выводит о статок
// от деления .
// Например:
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно

// void Method_1()
// {
//     Console.Write("Input first number: ");
//     string? inputLineA = Console.ReadLine(); //обращение к пользователю, переменная строка string
//     Console.Write("Input second number: ");
//     string? inputLineB = Console.ReadLine();//обращение к пользователюб переменная строка string
//     if (inputLineA != null && inputLineB != null) //условие если строки inputLineA и inputLineВ не пустые
//     {
//         int inputNumberA = int.Parse(inputLineA); //оператор превращения переменной string (строки) в переменную integer (число)
//         int inputNumberB = int.Parse(inputLineB); // inputNumberA присваивается inputLineA (inputNumberA = inputLineA)

//         Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("остаток от деления: " + inputNumberB % inputNumberA));
//     }
// }

// void Method_2()
// {
//     Console.Write("Input first number: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Input second number: ");
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int inputNumberA = int.Parse(inputLineA);
//         int inputNumberB = int.Parse(inputLineB);

//         Console.WriteLine(inputNumberB % inputNumberA == 0 ? "кратно" : inputNumberB % inputNumberA);

//     }
// }

// Вариант программы через методы 

int inputNumberA = 0; //объявляем NumberA и NumberВ как глобальные переменные
int inputNumberB = 0; // это значит что эти переменные доступны всем void. то есть не использовать int inputNumber
bool result = false; // false = пустая (нет значения)
ReadData();
ConculateData();
PrintData();

void ReadData() //получаем два числа от пользователя
{
    Console.Write("Input first number: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Input second number: ");
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);
    }
}

void ConculateData()  // определяем кратность чисел
{
    result = (inputNumberB % inputNumberA == 0); //посчитали кратно ли В к А
}

void PrintData() //выводим результат
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("остаток от деления: " + inputNumberB % inputNumberA);
    }
}



// Method_1();
// Method_2();
