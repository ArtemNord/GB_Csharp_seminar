// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


int Number(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return (i);

}

Console.WriteLine(Number(234));
Console.WriteLine(Number(457878));