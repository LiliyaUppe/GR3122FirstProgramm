// #47 Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//запрос данных у пользователя размера масссива mxn и рондомные числа
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int row, int column, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[row, column];

    for (int i = 0; i < row; i++) //индекс строки
    {
        for (int j = 0; j < column; j++) // индекс столбца
        {
            array2D[i, j] = Math.Round(rand.Next(downBorder, topBorder) * rand.NextDouble(), 2);
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

// цветовая гамма
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


//  печать цветного двумерного массива
void Print2DArrayColore(string ReadData)
{
    foreach (char symbol in ReadData)
    {
        Console.ForegroundColor = col[new System.Random().Next(0,16)];
        Console.Write(symbol);
       Console.ResetColor(); 
    }
}

int row = ReadData("Input number of rows m: ");
int column = ReadData("Input number of columns n: ");
int downBorder = ReadData("Input down border of random: ");
int topBorder = ReadData("Input top border of random: ");

double[,] arr2D = Fill2DArray(row, column, downBorder, topBorder);
Print2DArray(arr2D);
// Print2DArrayColore(arr2D);