using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


FulltimeEmployee Huy = new FulltimeEmployee();
Huy.Id = 1;
Huy.Name = "Huy";
Console.WriteLine(Huy.callSalary());

ParttimeEmployee Danh = new ParttimeEmployee();
Danh.WorkingHour = 2;
Danh.Name = "Danh";
Danh.Id = 2;
Console.WriteLine("Lương của Danh : " + Danh.callSalary());

FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    Name = "Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"
};

Console.WriteLine("===========================Thông tin của obama======================");
Console.WriteLine(obama);

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 200,
    IdCard = "666",
    Name = "Trump",
    Birthday = new DateTime(1999, 2, 2),
    WorkingHour = 3
};

Console.WriteLine("=====================Thông tin của Trump=========================");
Console.WriteLine(trump);