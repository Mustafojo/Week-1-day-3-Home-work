//Section 1
void PrintStars(int n)
{
   for (int i = 0; i < n; i++)
   {
        System.Console.Write("*");
   }
}
int a = Convert.ToInt32(Console.ReadLine());
PrintStars(a);
System.Console.WriteLine("-----------------------------");

//Section 2
void PrintSquare(int n)
{
    for (int i = 0; i < n; i++)
    {
        PrintStars(n);
        System.Console.WriteLine("");
    }
}
PrintSquare(a);
System.Console.WriteLine("-----------------------------");

//Section 3
void PrintRectangle(int width, int height)
{
    for (int i = 0; i < width; i++)
    {
        PrintStars(17);
        System.Console.WriteLine();
    }
}
PrintRectangle(3,17);
System.Console.WriteLine("-----------------------------");

//Section 4
void PrintTriangle(int size)
{
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("*");
    }
}
PrintTriangle(4);






