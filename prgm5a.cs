using System;
using System.Text;
					
public class Program {
   public static void Main() {
       //mutable string
       Console.WriteLine("This is mutable string");
      StringBuilder str = new StringBuilder("Web World!!",30);
      str.Replace("World", "Arena");
		
      Console.WriteLine(str);

      // immutable string
         string str1 = "Benzene";
         string str2 = "Ben";
         Console.WriteLine("");
         Console.WriteLine("This is immuable string");

         if (String.Compare(str1, str2) == 0) {
            Console.WriteLine(str1 + " and " + str2 +  " are equal strings.");
         } else {
            Console.WriteLine(str1 + " and " + str2 + " are not equal strings.");
         }
         Console.ReadLine() ;
      }
   }
