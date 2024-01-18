void Reverse(int n)
{
    for (int i = n; i > 0; i/=10)
    {
        System.Console.Write(i%10);
        
    }
}

Reverse(811);
