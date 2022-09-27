// #58 Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//  Чтение данных из консоли
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
            Console.Write($"{array[i, j]}  ");
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

// умножение матриц
int[,] Multiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        throw new Exception("Матрицы нельзя перемножить");
    }
    int[,] multiplArray = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
                multiplArray[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
    return multiplArray;
}

// // Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

int m = ReadData("Введите количество строк для 1-ой матрицы M: ");
int n = ReadData("Введите количество столбцов для 1-ой матрицы N: ");
int k = ReadData("Введите количество строк для 2-ой матрицы K: ");
int l = ReadData("Введите количество столбцов для 2-ой матрицы L: ");

Console.WriteLine();
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[k, l];

Fill2DArray(firstMatrix, 1, 9);
Print2DArray(firstMatrix);
Console.WriteLine();
Fill2DArray(secondMatrix, 1, 9);
Print2DArray(secondMatrix);

int[,] result = Multiplication(firstMatrix, secondMatrix);
Console.WriteLine("Произведение матриц равно:");
Console.WriteLine();
Print2DArray(result);

