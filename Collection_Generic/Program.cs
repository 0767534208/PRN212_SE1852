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
    Id = 5,
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

Console.Write("Nhập Id nhân viên muốn sửa: ");
string inputUpdate = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(inputUpdate) && int.TryParse(inputUpdate, out int idToUpdate))
{
    Employee empToUpdate = null;
    for (int i = 0; i < employees.Count; i++)
    {
        if (employees[i].Id == idToUpdate)
        {
            empToUpdate = employees[i];
            break;
        }
    }

    if (empToUpdate == null)
    {
        Console.WriteLine($"Không tìm thấy nhân viên có Id = {idToUpdate}");
    }
    else
    {
        Console.WriteLine("Thông tin hiện tại của nhân viên:");
        Console.WriteLine(empToUpdate);

        // Nhập Name mới
        Console.Write("Nhập tên mới: ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newName))
            empToUpdate.Name = newName;

        // Nhập IdCard mới
        Console.Write("Nhập IdCard mới: ");
        string newIdCard = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newIdCard))
            empToUpdate.IdCard = newIdCard;

        // Nhập Birthday mới
        Console.Write("Nhập ngày sinh mới: ");
        string newBirthdayStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newBirthdayStr))
        {
            if (DateTime.TryParseExact(newBirthdayStr, "dd/MM/yyyy", null,
                                       System.Globalization.DateTimeStyles.None, out DateTime newBirthday))
            {
                empToUpdate.Birthday = newBirthday;
            }
            else
            {
                Console.WriteLine("Nhập ngày sinh không phù hợp");
            }
        }

        // Nếu là ParttimeEmployee, cập nhật thêm WorkingHour
        if (empToUpdate is ParttimeEmployee pt)
        {
            Console.Write("Nhập giờ làm mới: ");
            string newWHStr = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newWHStr) && int.TryParse(newWHStr, out int newWH))
            {
                pt.WorkingHour = newWH;
            }
        }

        Console.WriteLine("Cập nhật xong. Thông tin sau khi sửa:");
        Console.WriteLine(empToUpdate);
    }
}
else
{
    Console.WriteLine("Bỏ qua cập nhật nhân viên.");
}

Console.WriteLine("--- Danh sách nhân viên sau khi cập nhật ---");
employees.ForEach(e => Console.WriteLine(e));


Console.Write("Nhập Id nhân viên muốn xóa: ");
string inputDelete = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(inputDelete) && int.TryParse(inputDelete, out int idToDelete))
{
    int indexToDelete = -1;
    for (int i = 0; i < employees.Count; i++)
    {
        if (employees[i].Id == idToDelete)
        {
            indexToDelete = i;
            break;
        }
    }

    if (indexToDelete < 0)
    {
        Console.WriteLine($"Không tìm thấy nhân viên có Id = {idToDelete}");
    }
    else
    {
        Console.WriteLine("Thông tin nhân viên sẽ xóa:");
        Console.WriteLine(employees[indexToDelete]);
        Console.Write("Bạn có chắc chắn muốn xóa? (Y/N): ");
        string confirm = Console.ReadLine();
        if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            employees.RemoveAt(indexToDelete);
            Console.WriteLine($"Đã xóa nhân viên Id={idToDelete} thành công.");
        }
        else
        {
            Console.WriteLine("Hủy xóa nhân viên.");
        }
    }
}
else
{
    Console.WriteLine("Bỏ qua xóa nhân viên.");
}


Console.WriteLine("\n--- Danh sách nhân viên hiện tại ---");
employees.ForEach(e => Console.WriteLine(e));

Console.ReadLine();