
int Sum(int number)
{
    int result = 0;

    for(int i = 0; i <= number; i++)
    {
        result = result + i;
    }
return result;
}

Console.WriteLine (Sum(7));
Console.WriteLine (Sum(28));
Console.WriteLine (Sum(9));
Console.WriteLine (Sum(2));