using System;

namespace program{
    class indexing{
        public int eno,salary;
        public string ename;

        public object this[int index]{
            get{
                if(index == 0){
                    return this.eno;
                }
                if(index == 1){
                    return this.ename;
                }
                if(index == 2){
                    return this.salary;
                }
            }
            set{
                if(index == 0){
                    eno = (int)value;
                }
                if(index == 1){
                    ename = (string)value;
                }
                if(index == 2){
                    salary = (int)value;
                }
            }
        }
        public static void Main(){
            indexing i = new indexing();
            i[0] = 1;
            i[1] = "Kaushik";
            i[2] = 10000;
            Console.WriteLine("Employee no: ",i[0]);
            Console.WriteLine("Employee Name: ",i[1]);
            Console.WriteLine("Employee salary: ",i[2]);
            Console.ReadLine();
        }
    }
}
