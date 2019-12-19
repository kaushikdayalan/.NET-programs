using System;
using System.Diagnostics;
using System.Text;

namespace exp
{
    class test{
        public static void Main(){
            int i;
            string s= " ";
            StringBuilder s1 = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            Stopwatch sw1 = new Stopwatch();
            sw.Start();
            for(i=0; i<100000;i++){
                s = s+i;    
            }
            sw.Stop();
            sw1.Start();
            for(i=0;i<100000;i++){
                s1.Append(i);
            }
            sw1.Stop();
            Console.WriteLine("time taken by imutable string: "+sw.ElapsedMilliseconds);
            Console.WriteLine("Time taken by mutable string: "+sw1.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}