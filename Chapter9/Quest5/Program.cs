// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень числа В с помощью рекурсии.


// int Print (int M, int N)
// {
//     if (N != 1)
//     {
//         M *= Print(M, N-1);
//     }
//     return M;
// }

// int result = Print(3, 3);

// Console.WriteLine($"{result}");

int SumNumber (int M, int N)
{
    int result = M;
    if (N != 1)
    {
        result *= SumNumber(M, N - 1);
    }
    return result;
}

Console.WriteLine($"Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = SumNumber(M, N);
Console.WriteLine($"Сумма цифр числа = {result}");