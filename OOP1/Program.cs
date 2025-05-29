using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


Category c1 = new Category();
c1.Id = 1;
c1.Name = "Cà Phê";
c1.PrintInfor();

Employee emp1 = new Employee();
emp1.Id = 1;
emp1.Name = "Huy";
emp1.Email = "huy123@gmail.com";
emp1.Phone = "1234567890";

Console.WriteLine($"Employee ID={emp1.Id}");

Console.WriteLine($"Employee Name={emp1.Name}");

emp1.PrintInfor();

Console.WriteLine("-----------------------------------------");
Console.WriteLine(emp1);

Employee emp2 = new Employee(2, "Huy vl", "huy1@gmail.com", "01924949494");
Console.WriteLine(emp2);