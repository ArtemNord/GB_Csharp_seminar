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

void SumPlusAndMinus(int[] arr)

{
    int MaxSum = 0;
    int MinSum = 0;

    for(int i = 0; i<arr.Length; i++)
    {
        
        if (arr[i]>=0)
        {
            MaxSum = MaxSum + arr[i];
        }
        else
        {
            MinSum = MinSum + arr[i];
        }
    }

    Console.WriteLine ($"{MaxSum}  {MinSum}");
}

SumPlusAndMinus(arr);