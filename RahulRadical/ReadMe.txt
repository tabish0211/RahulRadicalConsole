git init//only one time to do
git add .
git commit -m "My first commit"
git remote add origin https://github.com/tabish0211/CICD-Console.git  ---only one time
git push -u origin master

//Day-1

            //IO--
            //className.MethodName
            Console.WriteLine("Hello World");
            Console.WriteLine(
            @"this is dotnet classese
            this is dotnet classese
            this is dotnet classese
            this is dotnet classese
            this is dotnet classese
            this is dotnet classese
            this is dotnet classese");

            string name = "Ramesh kumar";
            int i = 10;
            long j = 10L;
            float d = 0.5f;
            double k = 0.000004d;
            bool flag = true;

            //reference type and value type
            //valu type is primitive datatype
            //int ,float,double,long,char---stack
            //reference type are created on heap--string,strinbuilder,array,classes

            Console.WriteLine(name);

			//Day-1 end

			//Day-2
			//how can two string input---concatenate it
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            string fullName=firstName +" "+ lastName +" "+age;



            Console.WriteLine(fullName);



			10

			2 4 8 16
			1 0 1 0

			0 1 1 0

			   //swapping--using 3rd
            int num1, num2, temp;
            num1 = 10;
            num2 = 20;

            Console.WriteLine("Before swapping:");
            Console.WriteLine(num1+" "+num2);

            //swapping 
            //temp = num1;//temp--10,num1--10
            //num1 = num2;//20--num1--overriden
            //num2 = temp;//10--temp

            //num1 = num1 + num2;//30
            //num2 = num1 - num2;//10
            //num1 = num1 - num2;//20

            num1 = num1 ^ num2;// 2 4 8 16
            num2 = num1 ^ num2;// 1 0 1 0
            num1 = num1 ^ num2;


            Console.WriteLine("After swapping:");
            Console.WriteLine(num1 + " " + num2);


			/// 561--5 +6+1=12
            int num = 561;
            int a, b, c;//a=1,b=6,c=5
            a = num % 10;//1
            num = num / 10;//561/10--56.1===56
            b = num % 10;//6
            num = num / 10;//5.6;//5
            c = num;

            int sum = a + b + c;
            Console.WriteLine("sum opf the digits "+sum);
            Console.WriteLine("sum opf the digits {0}",sum);


			//Decision
            if (true)
            {
                
            }
            else
            {
                //false
            }

            //ladder if-else
            if (true)
            {
                
            }
            else if (true)
            {
                
            }

            else
            {

            }

            int caseValue = 1;
            switch (caseValue)
            {
                case 1:
                    //few statement
                    break;
                case 2:
                    //few works
                    break;
                default:
                    //few works if nothing matches above
                    break;
            }

            int b = 20, c = 30;
            int a = b > c ? 1 : 0;

			 //looping--for fixed counter--limit

            for (int i = 0; i < 10; i++)
            {
                
            }

            //top-testing--how many testing
            int j = 1;
            while (j==1)
            {
                Console.WriteLine("hey");
                j = 2;

            }

            //bottom testing
            do
            {
                
            } while (true);

            //foreach (var item in collection)
            //{
                
            //}


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
			//Day-2 End

			//Day-3 start

			 //WAP to find eldest amongst three friends
            //Amar Akbar Anthony

            Console.WriteLine("Enter age for Amar");
            int amarAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age for Akbar");
            int akbarAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age for Anthony");
            int anthonyAge = Convert.ToInt32(Console.ReadLine());

            //comparison

            if (amarAge>akbarAge)
            {
                if (amarAge>anthonyAge)
                {
                    Console.WriteLine("amar is eldest one");
                }
                else
                {
                    Console.WriteLine("Anthony is eldest one");

                }
                
            }
            else
            {
                if (akbarAge > anthonyAge)
                {
                    Console.WriteLine("akbar is eldest one");
                }
                else
                {
                    Console.WriteLine("Anthony is eldest one");

                }

            }


			//assignment
			WAP to find count of even and odd numbers in the given range
			5---20

			
           //WAP to find count of lower,upper and special case in the given string
            //Tabish0211@gmail.com
            //T-1,l-13,n-4 s-2

            //@--64--. 46

            string str = "Tabish0211@gmail.com";
            char[] charArr = str.ToCharArray();
            int upperCaseCount = 0, lowerCaseCount = 0, numericCount = 0, specialSymbolCount = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                int asciiVal=Convert.ToInt32(charArr[i]);

                if (asciiVal>=65 && asciiVal<=90)
                {
                    upperCaseCount++;
                }
                else if (asciiVal>=97 && asciiVal<=122)
                {
                    lowerCaseCount++;
                }
                else if (asciiVal>=48 && asciiVal<=57)
                {
                    numericCount++;
                }
                else if (asciiVal>=58 && asciiVal<=64)
                {
                    specialSymbolCount++;
                }
                else if (asciiVal>=58 && asciiVal<=64)
                {
                    
                }
            }

            Console.WriteLine("uppercase count:{0} and lowercase count :{1} numeric count :{2} specialcase count :{3}",upperCaseCount,lowerCaseCount,numericCount,specialSymbolCount);
			



			//WAP to display all the leap years in the given range and show count of the leap years.
            //1900---2020---count--what are those
            //yr%400----ly
            //yr%4==0 yr%100!=0--ly
            //no leapyr 

            Console.WriteLine("Enter starting point");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end point");
            int end = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int year = start; year <= end; year++)
            {
                if (year%400==0)
                {
                    Console.WriteLine(year);
                    count++;

                }
                else if (year%4==0 && year%100!=0)
                {
                    Console.WriteLine(year);
                    count++;
                }
            }

            Console.WriteLine("the total number of leap years in between {0} to  {1} is {2}", start, end, count);
			
			

			//Assignment: WAP to find factorials of every number given in the range.
			//2 5---2
			//3--6


			//Day-3 End

			//Day-4 -start
			//break---continue

            for (int i = 1; i < 11; i++)
            {
                //if (i==6)
                //{
                //    break;
                //}
                if (i==6)
                {
                    continue;
                }
                Console.WriteLine(2 * i);
            }




			class Program
    {
        //entry point method
        //sharable
        static int x;
        static void Main()
        {
            //static methods only calls static methods or static variables...
            //non static variables like class instance data members are not directly accissible in the static methods
            Console.WriteLine(x);
            Show();
            int result = Sum();
            Console.WriteLine(2*result);
            MethodWithParams("Rakesh");
            Console.ReadLine();
        }

        //Default methods
        static void Show()
        {
            Console.WriteLine("I am show method");
        }

        static int Sum()
        {
            int x = 1, y = 2;
            return x + y;
        }

        //parametrized
        static void MethodWithParams(string value)
        {
            value = "Mr/Miss" + value;
            Console.WriteLine(value);
        }

    }



	  
        static void Main()
        {

            int n1 = 5, n2 = 6;
            int r;
            Sum(ref n1,ref n2,out r);
            Console.WriteLine(r);
            
            Console.ReadLine();
        }

        static void Sum(ref int x,ref int y,out int r)
        {
            r = x + y;
                   
        }



		    //var--should be initialised ---var x;x=10;
            //assigning=//calculation
            var r = 2 + 3;
           // r = "Rakesh";

            var s="Tabish "+ "Ahmad";


            //dynamic--C# 4.0--2010
            dynamic t ;
            t= 1 + 2;//resolved runtime
            t = "Rahul";



			static void Main()
        {
            //SetDetails("t", 13, 12000);
           // SetDetails(age: 12, name: "Rahul", salary: 1);
            Discount();//normal customer
            Discount(20);//Silver customer
            MethodforOptiopnal();
            MethodforOptiopnal(1,2);
            MethodforOptiopnal(1,2,3);
            Console.ReadLine();
        }

        static void SetDetails(string name, int age, int salary)
        { 
        
        
        }

        static void Discount(int discount=10)//optional parameter
        { 
        
        
        }



        static void MethodforOptiopnal(int x=2,int y=0,int z=0)//optional parameter
        {


        }


		 //post or pre
            int x = 1;
            int y = x++ + ++x;
            Console.WriteLine(y);//4
            Console.WriteLine(x);//3
			//Day-4-End

			//Day-5-Start

			private int _Id;

        public int Id
        {
            set {

                _Id = value;
            
            }
            get {

                return _Id;
            }
        
        }

        internal void SetData(int p)
        {
            _Id = p;
        }

        internal int GetData()
        {
            return _Id;
        }





		public int Id { get; private set; }


        //constructor overloading
        public Customer()
        {
            Id = 1001;

            Console.WriteLine("this is default");
        }

        public Customer(int id)
        {
            Id = id ;
            Console.WriteLine("this is with params");
        }

        //CLR
        static Customer()
        {

            Console.WriteLine("I will be called first");
        }

			//Day-5-End