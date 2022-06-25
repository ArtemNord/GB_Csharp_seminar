// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

double [] CreatArray()
{
    double [] array = new double [10];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (1, 10);
    }
    return array;
}
double [] arr = CreatArray();


double [] CreatArraySumElements(double [] array)
{
    double [] number = new double [10];
    int length = array.Length;
    
    for (int i = 0; i < array.Length/2; i++)
    {
        number[i] = array[i] * (array[length-1]);
        length = length - 1;
    }
    return number;
}
double [] number = CreatArraySumElements(arr);



void ShowArray(double [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ShowArray(arr);
Console.WriteLine();
ShowArray(number);