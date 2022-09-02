///============================================================================================================
// # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
// 2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
//============================================================================================================
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    if (inputNumberA > inputNumberB && inputNumberA > inputNumberC)
    {
        Console.WriteLine(inputLineA);
    }
    if (inputNumberA < inputNumberB && inputNumberB > inputNumberC)
    {
        Console.WriteLine(inputLineB);
    }
    if (inputNumberC > inputNumberB && inputNumberC > inputNumberA)
    {
        Console.WriteLine(inputLineC);
    }
}