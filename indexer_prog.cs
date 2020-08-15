using System;

class indexer_prog{
    public int regno;
    public string name;
    public indexer_prog(int regno, string name){
        this.regno = regno;
        this.name = name;
    }
    public object this [int index]{
        get{
            if (index == 0){
                return regno;
            }
            else if (index == 1){
                return name;
            }
            else{
                return null;
            }
        }
        set{
            if (index == 0){
                regno = (int)value;
            }
            else if(index == 1){
                name = (string)value;
            }
        }
    }
    public static void Main(){
        indexer_prog indexer_p = new indexer_prog(12,"kaushik");
        Console.WriteLine("Regno: "+indexer_p[0]);
        Console.WriteLine("Name: "+indexer_p[1]);
        indexer_p[0] = 18;
        indexer_p[1] = "Ruth";
        Console.WriteLine("changed Regno: "+indexer_p[0]);
        Console.WriteLine("changed Name: "+indexer_p[1]);
        Console.ReadLine();
    }

}