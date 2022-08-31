//============================================================================================================
// # 0 Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное само на себя).
//============================================================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = 0;

    DateTime d1 = DateTime.Now;
for(int i = 0; i < 100000; i++)
{
    outNumber = inputNumber * inputNumber;
}

    DateTime d2 = DateTime.Now;
    Console.WriteLine(d2-d1);

    //int outNumber = inputNumber*inputNumber;

Console.WriteLine(outNumber);
}