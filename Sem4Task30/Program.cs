// #30 Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

// решение данной задачи будет сводиться к 2 методам
// 1. GenarateArray(); - сгенерировать метод
//2. PrintArray(); - вывести на печать массив 

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
 
 //генерирование массива
int[] GenArray(int arrayLength) //метод принимает на вход длинну массисва
// int[] - квадратные скобки, тк на вход принемает массив
{
     Random rnd = new Random ();
    int[] array = new int [arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rnd.Next(0,2);
    }
    return array; 
}
// Печать результата
void PrintArray (int[] array)
{
    for(int i = 0; i<array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1]);
    }


int arrayLength = ReadData("Input array length: ");
int[] array = GenArray(arrayLength);
PrintArray(array);

// PrintArray(GenArray(ReadData("Input number ")));