// Напишите программу, которая выводит массив из 8 элементов,
// заполненный 0 и 1 в случайном порядке.


int Sum(int number)
{
    int result = 1;

    for(int i = 1; i <= number; i++)
    {
        result = result * i;
    }
return result;
}

Console.WriteLine (Sum(4));
Console.WriteLine (Sum(5));
Console.WriteLine (Sum(9));
Console.WriteLine (Sum(2));