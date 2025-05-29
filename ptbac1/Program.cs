using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Giải phương trình bậc 1 : ax + b = 0");

Console.WriteLine("Nhập a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Nhập b: ");
double b = double.Parse(Console.ReadLine());



if(a == 0 && b == 0)
{
    Console.WriteLine("Phương trình vô số nghiệm");
}
else if(a == 0 && b != 0)
{
    Console.WriteLine("Phương trình vô nghiệm");
}
else
{
    Console.WriteLine("x = {0} ", -b / a );
}

Console.ReadLine();