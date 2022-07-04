void PrintNumberExtra (int M, int N, int step)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumberExtra(M + step, N, step);

    }
}

Console.WriteLine($"Введите от кокого числа: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите до какого числа: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите шаг: ");
int step = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintNumberExtra(M, N, step);