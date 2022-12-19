Console.WriteLine("enter 1st positive number");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd positive number");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("the perfect number(s) between " + n1 + " and " + n2 + " is/are");

if (n1 > n2)
{
    int swap;
    swap = n1;
    n1 = n2;
    n2 = swap;

}
if (n1 <= 5)
    n1 = 6;
for (int i = n1; i <= n2; i++)
{
    int sum = 0;
    for (int j = 1; j <= i / 2; j++)
    {
        if (i % j == 0)

            sum += j;

    }
    if (sum == i)
        Console.WriteLine(i);
}

