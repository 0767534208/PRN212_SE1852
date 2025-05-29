using OOP2;
using OOP2_Review_as_Library;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee  e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Huy";
e1.Birthday = new DateTime(2003, 1, 5);
Console.WriteLine("Thông tin của e1");
Console.WriteLine(e1);

Console.WriteLine("Age = " + e1.TinhTuoi());