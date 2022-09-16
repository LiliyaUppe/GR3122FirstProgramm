// #31 Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отдельно отрицательных и отдельно положительных
// элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма
// отрицательных равна -20.

// Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line);  // Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0");   // Считываем число
    return number;  // Возвращаем значение
}

// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBoard, int topBoard)
{
    Random numSintezator = new Random(); //Генератор случайных чисел
    int[] arr = new int[num];   //Создаем массив
    if (downBoard < topBoard)   //Тест границ
    {
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBoard, topBoard + 1);
        }
    }
    return arr;  //Возвращаем результат
}

// //Печатае одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
 
 //метод подсчета сумм -/+ чисел
int[] NegotivPositivSums(int[] arr) //метод с двумерным массивом через int[] array
{
    int[] sums = new int[2]; // двумерный массив ([2] - это его длина 2 элемента, то есть будут две переменные - + и - суммы
    for (int i = 0; i < arr.Length; i++) // цикл чтобы пройти по всем элементам массива
    {
        if (arr[i] > 0) //условие для положительных элементов массива
        {
            sums[0] += arr[i]; // аккумулятор суммы + чисел массива
        }
        else
        {
            sums[1] += arr[i]; //аккумулятор суммы - чисел массива
        }
    }
    return sums;
}

// вывод результата
void PrintResult (string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Input array length: ");
int downBoard = ReadData("Input down board of array: ");
int topBoard = ReadData("Input top board of array: ");

int[] inputArray = FillArray(arrayLength,downBoard,topBoard); // эквивалентно int[] inputArray = FillArray (12,-9,9)
Print1DArr(inputArray); // печать самого массива

int[] sumArray = NegotivPositivSums(inputArray);

PrintResult("Sum >0: "+sumArray[0]+ " Sum <0: "+sumArray[1]);
Print1DArr(sumArray);

// string RandowArr(int lng, int from, int to)
// {
//     int[] array = new int[lng];
//     Random rnd = new Random();

//     int sumNeg = 0;
//     int sumPos = 0;
//     for (int i = 0; i < lng; i++)
//     {
//         array[i] = rnd.Next(from, to + 1);
//         if (array[i] > 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }

//     return (string.Join(", ", array) + "\n " + sumPos + " " + sumNeg);
// }
// "\n " - это символ вставляется для перехода на новую строку

// Console.Write(RandowArr(12, -9, 9));