//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.WriteLine("Для того чтобы узнать является ли одно число квадратом другого, введите их: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = B;

if (max < min)
{
    max = B;
    min = A;
}

int R = max % min;

if (R == 0)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}