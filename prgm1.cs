using System;
//using System.Collections.Generic;
//using System.Text;

class race
  {
   public static void Main(string[] args)
      {
         if(args.Length>0)
          {
   Console.WriteLine("Arguements passed by the programmer");
       foreach(object obj in args)
           {
              Console.WriteLine(obj);
            }
            }
else{
          Console.WriteLine("No arguements passed by the programmer");
    }
    Console.ReadLine();
       }
   }

