// #68 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//функция Аккермана
int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    return numberN + 1;
  else
    if ((numberN == 0) && (numberM > 0))
      return Akkerman(numberM - 1, 1);
    else
      return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
}


int numberM = ReadData("Введите числа m: ");
int numberN = ReadData("Введите числа n: ");
int result = Akkerman(numberM, numberN);

Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) = {result}");

