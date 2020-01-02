using System;
class passByRefference{
    public void exchange(ref int x){
        x = 100;
    }
    public static void Main(){
        int x=10;
        Console.WriteLine("x = "+x);
        passByRefference p = new passByRefference();
        p.exchange(ref x);
        Console.WriteLine("x after refference = "+x);
        Console.ReadLine();
    }
}