using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRadical
{
    class Program
    {
        static void Main()
        {
            string name = "Ramesh";//immutable--you cant modify---heap--1x
            name = name + " Kumar";//creates new memory---2x---makes slow processing string calculation
            Console.WriteLine(name);

            StringBuilder strBuild = new StringBuilder("Ramesh");//mutable--raeding from a file --
            strBuild.Append(" Kumar");
            Console.WriteLine(strBuild);
            Console.ReadLine();
        }

       
        

    }
}
