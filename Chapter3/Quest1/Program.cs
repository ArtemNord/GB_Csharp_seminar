void CoordinatesSearch(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Параметры некорректны");
    }
    else
    {
        if(x > 0 && y > 0) Console.WriteLine("1");
        if(x > 0 && y < 0) Console.WriteLine("4");
        if(x < 0 && y > 0) Console.WriteLine("2");
        if(x < 0 && y < 0) Console.WriteLine("3");
    }
}

CoordinatesSearch(2,3);
CoordinatesSearch(-2,3);
CoordinatesSearch(2,-3);
CoordinatesSearch(-2,-3);
CoordinatesSearch(0,0);