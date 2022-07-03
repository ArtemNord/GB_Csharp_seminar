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

void Shift(int[,] array)
{
    int length = array.GetLength(0)*array.GetLength(1);
    int [] temp = new int [length];
    int result = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[count] = array [i,j];
            Console.Write($"{temp[i]} ");
            if (array [i,j] == temp[i+1])
            {
                result++;
                Console.WriteLine($"= {result}");
            }
            else 
            {
                temp[i] = array [i,j];
            }
            count++;
        }
    }
    ($"{temp}");
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
Shift(matrix);