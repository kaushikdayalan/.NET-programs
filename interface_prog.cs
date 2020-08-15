using System;

interface itfc1{
    void get_sum(int a, int b);
    void get_mul(int a, int b);   
}

interface itfc2{
    void get_sub(int a, int b);
    void get_div(int a, int b);
}

class interface_testing:itfc1, itfc2{
    public void get_sum(int a, int b){
        Console.WriteLine("Sum: "+(a+b));
    }
    public void get_mul(int a, int b){
        Console.WriteLine("Product: "+(a*b));
    }
    public void get_sub(int a, int b){
        Console.WriteLine("Difference: "+(a-b));
    }
    public void get_div(int a, int b){
        Console.WriteLine("Quotient: "+(a/b));
    }
    public static void Main(){
        interface_testing inter_test = new interface_testing();
        inter_test.get_sum(10,15);
        inter_test.get_mul(2,4);
        inter_test.get_sub(9,5);
        inter_test.get_div(10,5);
        Console.ReadLine();
    }
}