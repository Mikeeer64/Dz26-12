string GetNamber(int x)
{
    if(x == 1) return $"{x}.";
    else return $"{x}, " + GetNamber(x - 1); 
}

Console.WriteLine(GetNamber(10));