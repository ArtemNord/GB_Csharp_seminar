void PrintNumberExtra (int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumberExtra(M + 1, N);

    }
}

PrintNumberExtra(2, 15);
