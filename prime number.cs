int n = 1;
int m = 9;
bool isPrime =true;

for (int j = n; j < m; j++)
{
    for (int i = j - 1; i > 1; i--)
    {
        if (j % i == 0)
            isPrime = false;
    }
    if (isPrime) Console.WriteLine(j );
    //else Console.Writeline(j + " Is not Prime");
    isPrime = true;
}
