int b = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[b];
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < b; i++)
{
    arr[i] += 5;
}
System.Console.WriteLine(a);

