// practice solution

public void Sum(int n)
{
    if (n == 1)
    {
        return 1;
    }
    
    return n + Sum(n - 1);
}