// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Math.Abs(Promt("Введите число N: "));
NumTable(n);

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    int numN = Convert.ToInt32(value);
    return numN;
}

void NumTable(int n)
{
    int currentNum = 1;
    int sqr = 1;
    while (currentNum <= n)
    {
        sqr = currentNum * currentNum * currentNum;
        Console.WriteLine(sqr);
        currentNum++;
    }
}