Console.WriteLine ("Введите номер дня недели: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A == 1)

{
    Console.WriteLine("Monday");
}

if (A == 2)

{
    Console.WriteLine("Tusday");
}

if (A == 3)

{
    Console.WriteLine("Wednesday");
}

if (A == 4)

{
    Console.WriteLine("Thursday");
}

if (A == 5)

{
    Console.WriteLine("Friday");
}

if (A == 6)

{
    Console.WriteLine("Saturday");
}

if (A == 7)

{
    Console.WriteLine("Sunday");
}

else
{
    Console.WriteLine("Введите корректный номер недели от 1 до 7");
}