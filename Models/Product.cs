using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Cid { get; set; }

    }
    public class Category1
    {
        public int Cid { get; set; }

        public string Cname { get; set; }
    }
    public class Employe5
    {
        public int empid { get; set; }
        public string empname { get; set; }

        public int salary { get; set; }
        public string Department { get; set; }
    }
}
