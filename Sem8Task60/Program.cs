// #60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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

// Печать трехмерного массива
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                 Console.Write($" {array3D[i, j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

// Заполнение трехмерного массива 
int[,,] Fill3DArray(int i, int j, int k, int min, int max)
{
    int element;
    int[,,] array3D = new int [i, j, k];
    for ( i = 0; i < array3D.GetLength(0); i++)
    {
        for ( j = 0; j < array3D.GetLength(1); j++)
        {
            for ( k = 0; k < array3D.GetLength(2); k++)
            {
               do                                            
               {                                            
                element = new Random().Next(min, max+1); // создается рондомный элемент
               }
               while (FindElement(array3D, element)); // выполняется условие до тех пор
                array3D[i, j, k] = element;           //пока не найдется совпадение
            }
        }
    }
    return array3D;
}

bool FindElement(int[,,]array3D, int element)
{
 for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == element) return true;
                if (array3D[i, j, k] == 0) return false; //условие для проверки только  заполненной части массива
            }
        }
    }
    return false;
}




int i = ReadData("Введите параметр Z: ");
int j = ReadData("Введите число строк Y: ");
int k = ReadData("Введите число столбцов Х: ");

int[,,] array3D = new int[i,j,k];
int min = 10;
int max = 99;
array3D = Fill3DArray(i, j, k, min, max);
Console.WriteLine();
Print3DArray(array3D);