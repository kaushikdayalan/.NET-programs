using System;

class except_handling{
    public static void Main(){
        int a, b, c;
        Console.WriteLine("Enter two numbers:");
        try{
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a/b;
        }
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex1){
            Console.WriteLine(ex1.Message);
        }
        Console.ReadLine();
    }
}