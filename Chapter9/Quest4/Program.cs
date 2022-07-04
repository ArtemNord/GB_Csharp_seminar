int SumNumber (int N)
{
    int result = 0;
    if (N != 0)
    {
        result += SumNumber(N/10) + N%10;
    }
    return result;
}


Console.WriteLine($"Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = SumNumber(N);
Console.WriteLine($"Сумма цифр числа = {result}");