using System;
using System.Collections;
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
           
            //LINQ--Language Integrated Query--
            //Queries like you sql but on in memory collections...List,ArrayList

            List<Student> lstStudents = new List<Student>();

            //Student s1 = new Student();
            //s1.Id = 101;
            //s1.Name = "Rakesh";

           // lstStudents.Add(s1);


            Student s2 = new Student();
            s2.Id = 102;
            s2.Name = "Ramesh";

            lstStudents.Add(s2);


            Student s3 = new Student();
            s3.Id = 103;
            s3.Name = "Ratnesh";

            //Student s4 = new Student();
            //s4.Id = 101;
            //s4.Name = "Rupesh";
            //lstStudents.Add(s4);

            Console.WriteLine("All the records");
            foreach (var item in lstStudents)
            {
                Console.WriteLine(item.Id +" "+item.Name);
            }

            //filter--101
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("Filter Records");
            //var filterReocrds = lstStudents.Where(s => s.Id == 101).ToList();

            //foreach (var item in filterReocrds)
            //{
            //    Console.WriteLine(item.Id+" "+item.Name);
            //}


            ////filter on first or default --basis

            //Console.WriteLine("Only first matching");
            //var filterFirstReocrd = lstStudents.Where(s => s.Id == 101).FirstOrDefault();
            //Console.WriteLine(filterFirstReocrd.Id + " " + filterFirstReocrd.Name);

            //filter on first  --basis

            //Console.WriteLine("Only first matching");
            //var filterFirstReocrd = lstStudents.Where(s => s.Id == 101).First();
            //Console.WriteLine(filterFirstReocrd.Id + " " + filterFirstReocrd.Name);


            //filter on Single()  --basis

            //Console.WriteLine("Only Single matching");
            //var filterFirstReocrd = lstStudents.Where(s => s.Id == 101).Single();
            //Console.WriteLine(filterFirstReocrd.Id + " " + filterFirstReocrd.Name);


            //filter on Single()  --basis

            Console.WriteLine("Only Single matching");
            var filterFirstReocrd = lstStudents.Where(s => s.Id == 101).SingleOrDefault();
            Console.WriteLine(filterFirstReocrd.Id + " " + filterFirstReocrd.Name);

            Console.ReadLine();
        }       
        

    }


    class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
    
    
    }

   
     
    
     

    

}
