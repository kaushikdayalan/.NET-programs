using System;
class outFunction{
    public void sum(int a, int b, out int c){
        c = a+b;
    }
    public void multiply(int a, int b, out int c){
        c = a*b;
    }
    public void divide(int a, int b, out int c){
        c = a/b;
    }
    public static void Main(){
        outFunction o = new outFunction();
        int a,b,c=0;
        c = Convert.ToInt32(c);
        int choice;
        Console.Write("Enter two numbers to perform mathematic functions: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Choose your operation:\n 1.sum 2.multiply\n 3.divide\n");
        choice = Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:{
                o.sum(a,b,out c);
                Console.WriteLine("the sum is " +c);
                Console.ReadLine();
                break;
            }
            case 2:{
                o.multiply(a,b,out c);
                Console.WriteLine("the product is ",+c);
                Console.ReadLine();
                break;
            }
            case 3:{
                o.divide(a,b,out c);
                Console.WriteLine("The qoutient is ",+c);
                Console.ReadLine();
                break;
            }
            default:{
                Console.WriteLine("Wrong input");
                Console.ReadLine();
                break;
            }
        }
    }
}