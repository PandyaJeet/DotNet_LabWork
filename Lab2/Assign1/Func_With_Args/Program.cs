class Hello
{
    int n1,n2;
    public Hello(Hello g)//Copy Construct
    {
        n1 = g.n1;
        n2 = g.n2;
    }
    public Hello(int a,int b)//Param Construct
    {
        n1 = a;
        n2 = b;
    }
    public Hello()//Default Construct
    {
        n1 = 1;
        n2 = 2;
    }
    public void Print()
    {
        Console.WriteLine("N is " + (n1+n2));
    }
    
}
class Notmain
{
    static void Main()
    {
        Hello hello = new Hello();
        Hello k = new Hello(10, 20);
        k.Print();
        Hello nothello = new Hello(hello);
        nothello.Print();
        hello.Print();
    }
}