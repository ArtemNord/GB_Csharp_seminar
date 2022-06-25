// Напишите программу замена эллементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.

int [] FillArray()
{
    int [] array = new int [12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int [] arr = FillArray();

void ShowArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
ShowArray(arr);

int [] Shift()
{   int [] array = arr;
    for(int i=0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] = array[i] * (-1);
        else array[i] = array[i] * (-1);
    }
    return array;
}

int [] arr2 = Shift();

ShowArray(arr2);