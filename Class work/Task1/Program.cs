void PrintFromNumberToOne(int number)
{
    for (int i = number; i > 0; i--)
    {
        System.Console.WriteLine(i);
    }
}

PrintFromNumberToOne(Convert.ToInt32(Console.ReadLine()));