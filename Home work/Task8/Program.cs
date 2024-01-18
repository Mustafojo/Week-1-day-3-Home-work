
int MinDigit(int a,int b,int c,int d)
{
    int min1 = Math.Min(a,b);
    int min2 = Math.Min(c,d);
    if(min1 > min2)
    {
        return min2;
    }
    else
    {
        return min1;
    }
}
System.Console.WriteLine(MinDigit(1,2,3,4));
