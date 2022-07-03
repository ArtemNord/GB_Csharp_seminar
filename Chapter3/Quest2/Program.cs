// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (х и у)

void CoordinatesSearch(int Quarter)
{
    if (Quarter < 1 || Quarter > 4)
    {
        Console.WriteLine("Параметры некорректны");
    }
    else
    {
        if(Quarter == 1) Console.WriteLine("x > 0, y > 0");
        if(Quarter == 4) Console.WriteLine("x > 0, y < 0");
        if(Quarter == 2) Console.WriteLine("x < 0, y > 0");
        if(Quarter == 3) Console.WriteLine("x < 0, y < 0");
    }
}

CoordinatesSearch(1);
CoordinatesSearch(2);
CoordinatesSearch(3);
CoordinatesSearch(4);
CoordinatesSearch(-1);
CoordinatesSearch(5);