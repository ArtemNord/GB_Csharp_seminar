// void PrintNumber(int number)
// {
//     Console.WriteLine(number);
//     if (number != 1)
//     {
//         PrintNumber(number - 1);
//     }
// }

// PrintNumber(10);

void PrintNumberExtra (int Start, int number)
{
    if (Start <= number)
    {
        Console.WriteLine(Start);
        PrintNumberExtra(Start + 1, number);

    }
}

PrintNumberExtra(1, 50);