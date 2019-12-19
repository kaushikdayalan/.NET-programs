using System;

namespace prg
{
    class test{
        public void calculate(int a,int b){
            int total = a+b;
            Console.WriteLine("The sum is "+total);
        }
        public int calculate(){
            int a,b;
            a = 10;
            b = 20;
            int product = a*b;
            return(product);
        }

    public static void Main(){
        test t = new test();
        int x;
        t.calculate(10,20);
        x = t.calculate(); 
        Console.WriteLine("Return function for product: "+x);
        Console.ReadLine();  
        }
    }
}