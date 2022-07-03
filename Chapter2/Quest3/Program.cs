// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
Console.WriteLine("Для того чтобы узнать кратны ли числа, введите их: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = B;

if (max < min)
{
    max = B;
    min = A;
}

int R = max / min;

int result = min * R;

if (max == result)
{
    Console.WriteLine("Кратно");
}

else
{
    int result1 = max - result;
    Console.WriteLine("Не кратно, остаток = ");
    Console.Write(result1);
}