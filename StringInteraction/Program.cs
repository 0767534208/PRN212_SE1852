using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//cách 1 nối chuỗi
string ho = "Dong";
string tenlot = "Quang";
string ten = "Huy";
string tenfull = ho + " " +  tenlot + " " + ten;
Console.WriteLine(tenfull);

//cách 2 nối chuỗi
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
string name = sb.ToString();
Console.WriteLine(name);
Console.ReadLine();

