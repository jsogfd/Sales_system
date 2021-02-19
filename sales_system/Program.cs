using sales_system.Class;
using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Saller s1 = new Saller();
            s1.Name = "Saller 1";
            s1.Age = 35;

            Saller s2 = new Saller();
            s2.Name = "Saller 2";
            s2.Age = 22;

            Saller s3 = new Saller();
            s3.Name = "Saller 3";
            s3.Age = 58;

            Product p1 = new Product();
            p1.NameProduct = "Rice";
            p1.Price = 3350;

            Product p2 = new Product();
            p2.NameProduct = "Sugar";
            p2.Price = 1550;

            Product p3 = new Product();
            p3.NameProduct = "water";
            p3.Price = 890;

            Sale sale1 = new Sale();
            sale1.product = p1;
            sale1.saller = s2;
            sale1.comment = "no founds  comments";

            Sale sale2 = new Sale();
            sale2.product = p2;
            sale2.saller = s3;
            sale2.comment = "no founds  comments";

            //What is the total of all sales?

          
        }
    }
}
