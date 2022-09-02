//============================================================================================================
// # 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3
//============================================================================================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > 0 && inputNumberB > 0 && inputNumberA > inputNumberB)
    {
        Console.WriteLine("inputNumberA > inputNumberB");
    }
    if (inputNumberA > 0 && inputNumberB > 0 && inputNumberA < inputNumberB)
    {
        Console.WriteLine("inputNumberA < inputNumberB");
    }

    if (inputNumberA < 0 && inputNumberB < 0 && (-1) * inputNumberA > (-1) * inputNumberB)
    {
        Console.WriteLine("inputNumberA < inputNumberB");
    }
    if (inputNumberA < 0 && inputNumberB < 0 && (-1) * inputNumberA < (-1) * inputNumberB)

    {
        Console.WriteLine("inputNumberA > inputNumberB");
    }

    if (inputNumberA < 0 && inputNumberB > 0)
    {
        Console.WriteLine("inputNumberA < NumberB");
    }

    if (inputNumberA > 0 && inputNumberB < 0)
    {
        Console.WriteLine("inputNumberA > inputNumberB");
    }
}