Console.WriteLine("Для того чтобы узнать кратно ли число 7 и 23, введите его: ");
int N = Convert.ToInt32(Console.ReadLine());

int A = N % 7;

if (A == 0)
{
    int B = N % 23;
    if (B == 0)
    {
        Console.WriteLine("Кратно");
    }
}

else
{
    Console.WriteLine("Не кратно");
}