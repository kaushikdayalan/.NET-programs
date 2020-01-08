using System;  
  
  
    class Pbr
    {  
        // User defined function  
        public void Show(ref int val)  
        {  
             val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function "+val);  
            // No return statement  
        }  
        // Main function, execution entry point of the program  
        static void Main(string[] args)  
        {  
            int val = 50;  
            Pbr pro= new Pbr(); // Creating Object  
            Console.WriteLine("Value before calling the function "+val);  
            pro.Show(ref val); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function " + val);  
            Console.ReadLine();
        }  
    }  
