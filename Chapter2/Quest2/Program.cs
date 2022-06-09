int N = new Random().Next(100,1000);
Console.WriteLine("Выпало число: ");
System.Console.WriteLine(N);

int A = N / 100;
int A1 = A * 10;

int C = N % 10;

int result = A1 + C;

Console.WriteLine("Result = ");
Console.Write(result);