// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке в отрезке [10, 99].

int [] CreatArray()
{
    int [] array = new int [123];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (1, 200);
    }
    return array;
}
int [] arr = CreatArray();


void PrintElement(int [] array)
{
    int number = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (99 > array[i] && 10 < array[i])
        {
            number = number + 1;
        }
    }
Console.WriteLine($"{number}");
}

PrintElement(arr);