using System;

public class number{
    public int x, y;
    public void get_num(){
        Console.WriteLine("Enter the first number");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        y = Convert.ToInt32(Console.ReadLine());
    }
}

public class add:number{
    public int sum;
    public void add_num(){
        sum = x + y;
        Console.WriteLine("Sum is "+sum);
    }
}

public class avg:add{
    public int average;
    public void get_avg(){
        average = (x + y + sum)/3;
        Console.WriteLine("The average is "+average);
    }

    public static void Main(){
        avg A = new avg();
        A.get_num();
        A.add_num();
        A.get_avg();
        Console.ReadLine();
    }
}