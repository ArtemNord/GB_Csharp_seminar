// Напишите программу, которая принимает на вход координаты двух точек
// и находит растояние между ними в 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Решение Марины
// void Distance(int x1, int y1, int x2, int y2)
// {
//     double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
//     Console.WriteLine ($"Расстояние = {distance}");
// }

// Console.WriteLine ("Введите координату х точки 1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату y точки 1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату х точки 2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату y точки 2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Distance(x1, y1, x2, y2);


// Решение через формулу с помошью Math.Sqrt и Math.Pow
void DistanceXY(int x1, int y1, int x2, int y2)
{
    Console.WriteLine(Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2))));
}
DistanceXY(3,4,5,6);

// Решение Марины с добавлением методов
// void Distance(int x1, int y1, int x2, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     Console.WriteLine($"Расстояние = {distance}");
// }

// Console.Write("Введите координату х точки 1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y точки 1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату х точки 2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y точки 2:");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Distance(x1, y1, x2, y2);