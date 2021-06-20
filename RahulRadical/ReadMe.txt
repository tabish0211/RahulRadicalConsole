

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

			//Day-2 End