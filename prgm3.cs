using System;


    class pbv

    {

        static void Main(string[] args)

        {

            int x = 10;

            Console.WriteLine("Variable Value Before Calling the Method:"+ x);

            Multiplication(x);

            Console.WriteLine("Variable Value After Calling the Method: {0}", x);

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();

        }

        public static void Multiplication(int a)

        {

            a *= a;

            Console.WriteLine("Variable Value Inside the Method: {0}", a);

        }

    }

