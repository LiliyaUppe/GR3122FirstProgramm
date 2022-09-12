// #29 Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 


// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    int arrayLength = int.Parse(Console.ReadLine() ?? "0");
    return arrayLength;
    int startNumber = int.Parse(Console.ReadLine() ?? "0");
    return startNumber;
    int stopNumber = int.Parse(Console.ReadLine() ?? "0");
    return stopNumber;
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
}

int arrayLength = ReadData("Input array length: ");
int startNumber = ReadData("Input start number: ");
int stopNumber = ReadData("Input stop number: ");
int start = startNumber;
int stop = stopNumber;
int[] array = GenArray(arrayLength, start, stop);
PrintArray(array);