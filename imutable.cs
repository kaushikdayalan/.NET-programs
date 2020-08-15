using System.Diagnostics;
using System.Text;
using System;

class test{
    public static void Main(){
        int i;
        string s1 = "";
        StringBuilder s2 = new StringBuilder();
        Stopwatch w1 = new Stopwatch();
        Stopwatch w2 = new Stopwatch();
        w1.Start();
        for ( i=0; i<10000; i++){
            s1 = s1+i;  
        }
        w1.Stop();
        w2.Start();
        for ( i=0; i<10000; i++){
            s2 = s2+i;
        }
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine("Immutable string: "+w1.ElapsedMilliseconds);
        Console.WriteLine("Mutable string: "+w2.ElapsedMilliseconds);
        Console.ReadLine();
    }
}