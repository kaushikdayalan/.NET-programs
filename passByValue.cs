using System;
class passByValue{
    public int multiply(int a, int b){
        int c = a*b;
        return c;
    }
    public static void Main(){
        int output;
        int x,y;
        Console.WriteLine("enter two numbers x,y: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        passByValue p = new passByValue();
        output = p.multiply(x,y);
        Console.WriteLine("answer obtained through pass by value "+output);
        Console.ReadLine();
    }
}