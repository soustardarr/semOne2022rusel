
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
if ((y <= 1 && y >= 0 && Math.Abs(x) <= 1) && (Math.Abs(x) + Math.Abs(y) <= 1))
{
    Console.WriteLine("принадлежит");
}
else if (Math.Abs(x) <= 1 && ((y >= -1 * x * x) && (y < 0)))
{
    Console.WriteLine("принадлежит");

}
else
{
    Console.WriteLine("не принадлежит");
}

