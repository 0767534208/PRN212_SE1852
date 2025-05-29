using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void giaibac1(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Phương trình vô số nghiệm");
    }
    else if (a == 0 & b != 0)
    {
        Console.WriteLine("Phương trình vô nghiệm");
    }
    else
    {
        Console.WriteLine("X = {0}", -b / a );
    }
}



void giaibac2(double a, double b, double c)
{
    if (a == 0)
    {
        giaibac1(b,c);
    }
    else
    {
        var delta = Math.Pow(b, 2) -  4 * a * c;
        if (delta < 0)
            Console.WriteLine("Phương trình vô nghiệm");
        else if (delta == 0)
            Console.WriteLine("X1=X2={0}", -b/(2*a));
        else
        {
            var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1={0} \n X2={1}", x1, x2);
        }
    }
}


Console.WriteLine("Giải phương trình bâc 2: a^2 + bx + c = 0 ");

Console.WriteLine("Nhập a: ");
var a = double.Parse(Console.ReadLine());

Console.WriteLine("Nhập b: ");
var b = double.Parse(Console.ReadLine());

Console.WriteLine("Nhập c: ");
var c = double.Parse(Console.ReadLine());

Console.WriteLine("{0}X^2+{1}x+{2}=0",a,b,c);
giaibac2 (a,b,c);
Console.ReadLine();