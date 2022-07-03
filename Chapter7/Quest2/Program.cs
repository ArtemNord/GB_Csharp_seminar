// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.

int [,] Table (int n, int m)
{
    int [,] table = new int [n, m];
    return table;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}



void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}



Console.WriteLine($"Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = Table (n , m);
Console.WriteLine();

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


