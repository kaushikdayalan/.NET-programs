using System;

namespace exp
{
    class test{
        public static void Main(){
            Console.WriteLine("enter 2 values to be divided: ");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a/b;
            Console.WriteLine("the answer is: ",c);
        }
        catch (DivideByZeroException e) {
            Console.WriteLine("error: {0}", e.Message);
         }
        catch(FormatException e)
        {
            Console.WriteLine("error: {0}", e.Message);
        }
        Console.ReadLine();
    }
        }
    }
