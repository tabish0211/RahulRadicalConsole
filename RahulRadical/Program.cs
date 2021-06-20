using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRadical
{
    class Program
    {
        //entry point method

        
        static void Main()
        {
         
            //array--1 2 3 4 ---memory size data type--int--4byte--char-2--2 byte
            //n---numbers values of the same type dont decalre n number of variables--use array

            //datatype[] arr_variable= new datatype[size];//1-D
            char[] arrChar = new char[10];
            int[] arrInt = new int[10];
            arrInt[3] = 10;

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            Console.ReadLine();
        }
    }
}
