int N = new Random().Next(10,100);
Console.WriteLine("Выпало число: ");
System.Console.WriteLine(N);
int A = N % 10;
int B = N / 10;

if (A > B)
{
    Console.WriteLine(A);
}

else
{
    Console.WriteLine(B);
}

// Код показывает максимальное число из двух в двузначном случайном числе.