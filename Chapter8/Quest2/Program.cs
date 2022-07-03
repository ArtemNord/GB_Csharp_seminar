// Задайте двумерный массив, напишите программу которая поменяет местами первую и последнюю стоку массива.


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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

bool Shift(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine($"Это не возможно");
        return false;
    }
    else
    {
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = array [i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    }
    return true;
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
if (Shift(matrix) == true)
{
    Console.WriteLine();
    PrintArray(matrix);
}