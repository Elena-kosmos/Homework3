// // напишите программу, которая принимает на вход координаты двух точек
// и находит растояние между ними в 3D пространстве
Console.Write("введите координату x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"расстояние между точками: {Math.Round(d,2)}");
