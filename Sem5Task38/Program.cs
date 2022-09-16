// #38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.


// Метод считывания данных пользователя
(int arrayLength, int startNumber, int stopNumber) ReadData(string line1, string line2, string line3)
{
    // Выводим сообщение
    Console.Write(line1);
    int arrayLength = int.Parse(Console.ReadLine() ?? "0");
    Console.Write(line2);
    int startNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.Write(line3);
    int stopNumber = int.Parse(Console.ReadLine() ?? "0");
    return (arrayLength, startNumber, stopNumber);
}
// Универсальный метод генерации и заполнения массива
int[] FillArray(int arrayLength, int startNumber, int stopNumber) 
{
    Random rnd = new Random(); //Генератор случайных чисел
    int[] array = new int[arrayLength];   //Создаем массив
    {
        //Заполняем массив
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(startNumber, stopNumber);
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

//метод разность  максимального и минимального элементов массива
int MaxMinRemainder(int[] RandomArray)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        if (RandomArray[i] > max) max = RandomArray[i];
        if (RandomArray[i] < min) min = RandomArray[i];
    }
    return ((int)max - (int)min);
}

// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


(int arrayLength, int startNumber, int stopNumber) askResult = ReadData("Input array length: ", "Input start number: ", "Input stop number: ");
int[] RandomArray = FillArray(askResult.arrayLength, askResult.startNumber, askResult.stopNumber);
PrintArray(RandomArray);

PrintResult($" max-min = {MaxMinRemainder(RandomArray)}");