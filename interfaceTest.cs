using System;
interface inter1{
    int add(int a, int b);
    void display(int a, int b);
}
class interfaceTesting:inter1{
    public int add(int a,int b){
        return a+b;
    }
    public void display(int a, int b){
        Console.WriteLine("Sum of two numbers is "+add(a,b));
    }
    public static void Main(){
        int x,y;
        Console.WriteLine("enter 2 numbers to add");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        interfaceTesting it = new interfaceTesting();
        it.display(x,y);
        Console.ReadLine();
    }
}

