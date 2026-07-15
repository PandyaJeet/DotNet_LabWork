class Hello
{
    public void print()
    {
        Console.WriteLine("Hello");
    }
    public void print(int a)
    {
        Console.WriteLine(a);
    }
    public void print(char a,char b)
    {
        Console.WriteLine(a + b);
    }
}
class Notmain
{
    static void Main()
    {
        Hello h = new Hello();
        h.print();
        h.print(10);
        h.print('a','b');
    }
}