// Напишите программу, которая выводит массив из 8 элементов,
// заполненный 0 и 1 в случайном порядке.

void Array(int number)
{
int [] Array = new int [number];

for (int i = 0; i < Array.Length; i++)
{
    Array [i] = new Random().Next (0, 2);
    Console.Write($" {Array[i]}");
}
}

Console.WriteLine("Укажите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Array(number);
