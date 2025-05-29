using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _email { get; set; }
        private string _phone { get; set; }

        public Employee()
        {
        }

        public Employee(int _id, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._name = _name;
            //hoặc
            Email = _email; //gọi setter cho Property Email
            Phone = _phone;
        }



        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void PrintInfor()
        {
            Console.WriteLine($"{Id}\t{Name}\t{Email}\t{Phone}");
        }

        public override string ToString()
        {
            string msg = $"{Id}\t{Name}\t{Email}\t{Phone}";
            return msg;
        }
    }
}
