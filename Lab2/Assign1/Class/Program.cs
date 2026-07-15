class hello
{
    public void printdata(int n1, int n2)
    {
        Console.Write("Sum of " + n1 + " and " + n2 + " is " + (n1 + n2));
    }
}
class main
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Enter a number 1 : ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number 2 : ");
        n2 = Convert.ToInt32(Console.ReadLine());
        hello hello = new hello();
        main h = new main();
        hello.printdata(n1,n2);
    }
}