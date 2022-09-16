// # 33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве и каков его номер.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// поиск заданного элемента в массиве
int FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return i;
        }
    }
    return -1;
}

// вывод ответа
void PrintAnswer(int index)
{
    Console.WriteLine(index>0 ? ("Элемент найден на позиции:"+index) : "Нет");
}

int arrLength = ReadData("Введите длину массива: "); // общение с пользователем
int start = ReadData("Введите минимальное значение: "); // общение с пользователем
int stop = ReadData("Введите максимальное значение: "); // общение с пользователем


int[] arr = GenArray(arrLength, start, stop); //генерация массива
PrintArray(arr); // печать массива
int num = ReadData("Введите искомое значение: "); //общение с пользователем
PrintAnswer(FindNumber(arr, num)); // ответ true/false

// // Универсальный метод генерации и заполнение массива
// int[] FillArray(int length,int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(topBorder, downBorder + 1);
//     }
//     return array;
// }

// // определяет является ли value элементом массива
// bool Contains(int[] array, int value)
// {
//     foreach (int item in array) // оператор эквивалентный for, но более удобный в синтаксисе
//    foreach берет все элементы из массива и по очереди выдает их в цикле, то есть итерратор спрятан внутри и мы его не видим
//  {
//         if(item == value)
//         return true;
//     }
//     return false;
// }

// // вывод массив
// void Print1DArray(int[] array)
// {
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }

// // вывод ответа
// void PrintAnswer(bool answer)
// {
//     Console.WriteLine(answer ? "Да" : "Нет"); //тернарный оператор
// }


// int[] array = FillArray(10, 0, 10);
// Print1DArray(array);
// Console.WriteLine("Ищем элемент: 10");
// PrintAnswer(Contains(array, 8));