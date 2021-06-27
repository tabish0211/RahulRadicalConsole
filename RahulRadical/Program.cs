using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RahulRadical
{
    class Program
    {

        static void Main()
        {
            Customer cust = new Customer(1001, "Rakesh");
            cust.ShowData();
            Console.ReadLine();
        }       
        

    }

    //DRY---
    class Customer
    {
        private int id;
        private string name;

        public Customer(int id)
        {
            this.id = id;

        }

        public Customer(int id,string name):this(id)
        {
            this.name = name;
            //this.id = id;

        }

        public void ShowData()
        {

            Console.WriteLine(this.id+""+this.name);
        
        }

    }

}
