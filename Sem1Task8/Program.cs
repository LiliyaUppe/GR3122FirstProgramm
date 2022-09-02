///============================================================================================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8
//============================================================================================================
string? inputLine = Console.ReadLine ();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 2)
    {
Console.WriteLine("input number >1");
    }
    int startIndex = 2;
    while (startIndex <= inputNumber - 2)
    {
        Console.Write(startIndex + ",");
        startIndex +=2;
    }
    if(startIndex % 2 == 0)
    {
        Console.Write(startIndex);
    }
}