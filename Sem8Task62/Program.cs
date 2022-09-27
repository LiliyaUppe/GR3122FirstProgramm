// #62 Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

// заполненеие спиралью
int[,] FillSpirallArray(int countRow, int countColumn)
{
    int count = 1;
    int startRow = 0;
    int endRow = countRow - 1;
    int startCol = 0;
    int endCol = countColumn - 1;
    int[,] array = new int[countRow, countColumn];
    int maxValue = countRow * countColumn;

    // пока все элементы не заполнены
    while (count < maxValue)
    {
        // проход слева направо
        for (int i = startCol; i <= endCol; i++)
        {
            array[startRow, i] = count++;
        }

        // сдвигаем верхнюю границу к центру
        startRow++;

        // проход сверху вниз
        for (int j = startRow; j <= endRow; j++)
        {
            array[j, endCol] = count++;
        }
        // сдвигаем правую границу
        endCol--;

        // проход справа налево
        for (int i = endCol; i >= startCol; i--)
        {
            array[endRow, i] = count++;
        }
        // сдвигаем нижнюю границу
        endRow--;
        // проход снизу вверх
        for (int j = endRow; j >= startRow; j--)
        {
            array[j, startCol] = count++;
        }
        // сдвигаем левую границу
        startCol++;
    }
    return array;
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] array = new int[m, n];
Console.WriteLine();
Print2DArray(FillSpirallArray( m,n));