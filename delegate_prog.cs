using System;

public delegate void deleadd(int x, int y);
public delegate string delestring(string s);
class delegate_usage{
    public static void add(int x, int y){
        Console.WriteLine("sum is "+(x+y));
    }
    public static string print_string(string s){
        return s;
    }

    public static void Main(){
        string s = "";
        deleadd d = new deleadd(add);
        delestring st = new delestring(print_string);
        d(5, 6);
        s = st("Hello World");
        Console.WriteLine(s);
        Console.ReadLine();

    }

}