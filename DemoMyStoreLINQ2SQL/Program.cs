using DemoMyStoreLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=HI\\SQLEXPRESS;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);

//Câu 1 : DÙng LINQ2SQL để lấy ra toàn bộ categories

var categories = context.Categories;
foreach(var cate in categories)
{
    Console.WriteLine($"Category ID: {cate.CategoryID}, Name: {cate.CategoryName}");
}

//Câu 2 : tìm chi tiết 1 danh mục khi biế t CategoryID

int cateid = 5;
Category category = context.Categories.FirstOrDefault(c => c.CategoryID == cateid);

if(category == null)
{
    Console.WriteLine($"Không tìm thấy danh mục có mã = {cateid}");
}
else
{
    Console.WriteLine($"tìm thấy danh mục có mã = {cateid}, chi tiết : ");
    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
}

////Câu 3 : thêm 1 danh mục
//Category cnew = new Category();
//cnew.CategoryName = "Thuốc trị ngu code";
//context.Categories.InsertOnSubmit(cnew);
//context.SubmitChanges();

////Câu 4 : thê mới nhiều danh mục cùng 1 lúc 
//List<Category> dsdm_new = new List<Category>();
//dsdm_new.Add(new Category() {CategoryName = "Laptop" });
//dsdm_new.Add(new Category() { CategoryName = "TV" });
//dsdm_new.Add(new Category() { CategoryName = "Phu Kiện" });
//context.Categories.InsertAllOnSubmit(dsdm_new);
//context.SubmitChanges();

//Câu 5 : sửa tên danh mục , nguyên tắc là tìm trươcs ròi tìm thấy mới sửa
Category c = (from x in context.Categories
              where x.CategoryID == 10
              select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if(c2 != null)
{
    c2.CategoryName = "Thuốc trị ngu code";
    context.SubmitChanges();
}

//Câu 6 : xóa danh mục , nguyên tắc là tìm trươcs ròi tìm thấy mới xóa

Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if(c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}

//Câu 7 : xóa tất cả danh mục mà không chứa bất cứ sản phẩm nào


var deteleC = context.Categories.Where(c => c.Products.Count == 0).ToList();
context.Categories.DeleteAllOnSubmit(deteleC);
context.SubmitChanges();
