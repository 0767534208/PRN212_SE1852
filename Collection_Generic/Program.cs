//ứng dụng Generic để quản lí nhân viên, thực hiện các thao tác CRUD
// C - Create -> thêm mới
// R - Read (Retrieve) -> truy vấn: xem, sắp xếp, lọc
// U - Update -> Chỉnh sửa dữ liệu
// D - Delete -> Xóa dữ liệu

// Câu 1 : Tạo 5 nhân viên, 4 fulltime, 1 parttime

using OOP2;
using System.Text;

List<Employee> employees = new List<Employee>();

FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Huy",
    IdCard = "666",
    Birthday = new DateTime(2002, 1, 5)
};

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Danh",
    IdCard = "333",
    Birthday = new DateTime(2007, 11, 5)
};

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Vy",
    IdCard = "111",
    Birthday = new DateTime(2000, 11, 5)
};

FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Long",
    IdCard = "999",
    Birthday = new DateTime(2003, 8, 5)
};

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 1,
    Name = "Duong",
    IdCard = "884",
    Birthday = new DateTime(1999, 12, 5),
    WorkingHour = 4
};

employees.Add(fe1);
employees.Add(fe2);
employees.Add(fe3);
employees.Add(fe4);
employees.Add(pe1);

//Câu 2 : Xuất toàn bộ thông tin nhân sự (R)
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Thông tin toàn bộ nhân sự");
//Cách 1 : Dùng Expression body (Lambda Expression)
employees.ForEach(e => Console.WriteLine(e));

//Cách 2 : Dùng for thông thường không dùng =>
Console.WriteLine("Cách for thông thường");
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

//Câu 3 : Sắp xếp nhân viên theo năm sinh tăng dần

for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if(ei.Birthday < ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}

Console.WriteLine("Employee sau khi sắp xếp: ");
employees.ForEach(e => Console.WriteLine(e));