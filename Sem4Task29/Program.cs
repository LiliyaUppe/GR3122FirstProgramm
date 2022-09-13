// #29 Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 


// Чтение данных из консоли
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

//генерирование массива
int[] GenArray(int arrayLength, int start, int stop) //метод принимает на вход длинну массисва, int[] - квадратные скобки- массив
{
    Random rnd = new Random();
    int[] outArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        outArray[i] = rnd.Next(start, stop);
    }
    return outArray;
}
// Печать результата
void PrintArray(int[] array)
{
    int i = 0;
    for (i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i] + ",");
    }
     Console.Write( array[i]);
}
 //вариант для миддлов, то есть продвинутых
(int arrayLength, int startNumber, int stopNumber) askResult = ReadData("Input array length: ", "Input start number: ", "Input stop number: ");
int[] array = GenArray(askResult.arrayLength, askResult.startNumber, askResult.stopNumber);
PrintArray(array);


// мой простой вариант
// int arrayLength = ReadData("Input array length: ");
// int startNumber = ReadData("Input start number: ");
// int stopNumber = ReadData("Input stop number: ");
// int start = startNumber;
// int stop = stopNumber;
// int[] array = GenArray(arrayLength, start, stop);
// PrintArray(array);