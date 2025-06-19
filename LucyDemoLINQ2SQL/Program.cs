using LucyDemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = "Data Source=HI\\SQLEXPRESS;Initial Catalog=Lucy_SalesData;User ID=sa;Password=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

var ds2 = (from c in context.Customers
           join o in context.Orders on c.CustomerID equals o.CustomerID
           join od in context.Order_Details on o.OrderID equals od.OrderID
           group od by new { c.CustomerID, c.ContactName } into g
           select new
           {
               CustomerID = g.Key.CustomerID,
               ContactName = g.Key.ContactName,
               TotalAmount = g.Sum(x => x.UnitPrice * x.Quantity)
           }).OrderByDescending(x => x.TotalAmount)
             .Take(3);

foreach (var item in ds2)
{
    Console.WriteLine(item.CustomerID + "\t" + item.ContactName + "\t" + item.TotalAmount);
}