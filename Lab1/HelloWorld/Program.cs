class Hello
{
    static void add()
    { 
        Console.Write("No1 : ");
        int no1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("No2 : ");
        int no2 = Convert.ToInt32(Console.ReadLine());
        int sum = no1 + no2;
        Console.WriteLine("Sum is " + sum);
    }
    static void greater()
    {
        Console.Write("No1 : ");
        int no1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("No2 : ");
        int no2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("No2 : ");
        int no3 = Convert.ToInt32(Console.ReadLine());
        if (no2 > no3 & no2 > no1) Console.WriteLine("No2 i.e. " + no2 + " is greater");
        else if (no1 > no2 & no1 > no3) Console.WriteLine("No1 i.e. " + no1 + " is greater");
        else if (no3 > no2 & no3 > no1) Console.WriteLine("No3 i.e. " + no3 + " is greater");
        else Console.WriteLine("All are equal");
    }
    static void Main()
    {
        Hello.greater();
    }
}