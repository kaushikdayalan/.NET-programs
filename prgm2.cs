using System; 
class overload
 { 
  
    // adding two integer values. 
    public int Add(int a, int b) 
    { 
        int sum = a + b; 
        return sum; 
    } 
  
    // adding three integer values. 
    public int Add(int a, int b, int c) 
    { 
        int sum = a + b + c; 
        return sum; 
    } 
  
    // Main Method 
    public static void Main(string[] args) 
    { 
  
        // Creating Object 
        overload ol = new overload(); 
  
        int sum1 = ol.Add(20, 30); 
        Console.WriteLine("sum of the two variables=" + sum1); 
        
  
        int sum2 = ol.Add(22, 20, 15); 
        Console.WriteLine("sum of the three variables=" + sum2); 
        Console.ReadLine();
    } 
} 