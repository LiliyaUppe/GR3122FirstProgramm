// #36  Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line);  // Выводим сообщение
    int arrayLength = int.Parse(Console.ReadLine() ?? "0");   // Считываем число
    return arrayLength;  // Возвращаем значение
}

// Универсальный метод генерации и заполнения массива
int[] FillArray(int arrayLength) //границы заполнения массива (-100:100)
{
    Random rnd = new Random(); //Генератор случайных чисел
    int[] array = new int[arrayLength];   //Создаем массив
    {
        //Заполняем массив
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-100, 100);
        }
    }
    return array;  //Возвращаем результат
}

// //Печатае одномерный массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//метод подсчета суммы элементов на нечетных позициях
int SumNumbersOnUnevenIndex(int[] RandomArray)
{
    int sum = 0;
    for (int i = 0; i < RandomArray.Length; i = i + 2)
    {
        sum = sum + RandomArray[i];
    }
    return sum;
}

// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// // число пар  в одномерном массиве (цикл в цикле со списком)- выдает две ошибки, я не знаю как их исправить
// int[] TwinsOfNumbers(int[] FillArray)
// {
//     List<int> list = new List<int>(); //создаем список из эдементов twin ( элементы совпадений)
//     for (int i = 0; i < FillArray.Length - 1; i++) // цикл - проходка по всем элементам исходного массива RandomArray с 0 до RandomArray.Length - 1 для поиска twin
//     {
//         if (list.IndexOf(FillArray[i] == -1)) //условие проверки элемента из list с элементом из RandomArray (их индексы) при очередной проходке - если элемент уже создал пару twin
//         {
//             for (int j = i + 1; j < FillArray.Length; j++) //цикл - проходка от выбранного элемента (j = i + 1) до последнего элемента j < RandomArray.Length исходного массива RandomArray для поиска twin
//             {
//                 if (FillArray[i] == FillArray[j]) //находим совпадение цифр twins
//                 {
//                     list.Add(FillArray[i]); // добавляем в list найденный twin
//                     break; // прекращаем цикл, то есть выходим из внутреннего цикла for (int j = i + 1; j < RandomArray.Length; j++)
//                 }
//             }
//         }
//     }
//     return list.ToArray(); // возвращаем list преобразованный в массив .ToArray()
// }


int number = ReadData("Input array length: ");
int[] RandomArray = FillArray(number);
PrintArray(RandomArray);
PrintResult($"Sum of numbers on uneven index = {SumNumbersOnUnevenIndex(RandomArray)}");

// int[] twin = TwinsOfNumbers(FillArray);
// PrintResult($"number of twin = {twin.Length}");