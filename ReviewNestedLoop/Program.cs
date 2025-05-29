using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//câu 1 : vẽ hình N

void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //chạy hết các cột trong 1 dòng
            if(j == 0 || j == n-1 || i==j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

//hinh1(10);

//Câu 2 : sắp xếp mảng tăng dần dùng do while lồng nhau

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void mySort(int[] arr)
{
    int i = 0;
    int j = i+1;
    do
    {
        do
        {
            if(arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }while (j < arr.Length -1);
        i++;
        j = i + 1;
    } while (i < arr.Length -1);
}

int[] arr = { 10, 3, 7, 2, 9 };
Console.WriteLine("Mảng trước khi sắp xếp");
foreach (int i in arr)
    Console.WriteLine($"{i} \n");
mySort(arr);
Console.WriteLine("Mảng sau khi sắp xếp");
foreach(int i in arr)
    Console.WriteLine($"{i} \n");