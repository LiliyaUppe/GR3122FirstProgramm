// #54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Упорядочивание двумерного массива
int[,] Update2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Row.Add(array[i, j]);
            Row.Sort(); //сортировка по возрастанию
            Row.Reverse(); //сортировка по убыванию
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Row[j];
        }
    }
    return array;
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] array = new int[m, n];


Fill2DArray(array, 1, 9);
Print2DArray(array);

Update2DArray(array);
Print2DArray(array);