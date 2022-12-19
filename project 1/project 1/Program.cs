Console.WriteLine("enter 1st positive integer number");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter 2nd positive integer number");
int n2 = int.Parse(Console.ReadLine());
int i, j;
bool z = false;
Console.WriteLine("prime number(s) between " + n1 + " and" + n2 + " is/are");
if (n1 > n2)
{
    int swap;
    swap = n1;
    n1 = n2;
    n2 = swap;
}
if (n1 == n2)
{
    if (n1 == 1 || n1 == 0)
        Console.WriteLine("there is no prime number");
    else if (n1 == 2)
        Console.WriteLine(n1);
    else
    {
        for (i = 2; i <= n1 / 2; i++)
        {
            if (n1 % i == 0)
            {
                z = true;
                Console.WriteLine("there is no prime number");
                break;
            }

        }
        if (z == false)
            Console.WriteLine(n1);
    }
}
else if (n1 == 0 || n1 == 1)
{
    n1 = 2;
    for (i = n1; i <= n2; i++)
    {
        for (j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                z = true;
                break;
            }
            else z = false;
        }
        if (z == false)
            Console.WriteLine(i);
    }
}

