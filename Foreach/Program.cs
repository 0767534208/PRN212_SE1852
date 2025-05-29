int sums(params int[] arr)
{
    int s = 0;
    foreach(int i in arr)
        s += i;
    return s;
}

int s1 = sums(1);
int s2 = sums(1,8,10);
int s3 = sums(1, 2, 14);
Console.WriteLine();