int GetNamber(int x, int y)
{
    int summ = 0;
    if(x == y) return y;
    else
    {
        summ = x + GetNamber(x + 1, y);
    }
    return summ;
}

Console.WriteLine(GetNamber(1, 15));