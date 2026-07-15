class ParentClass
{
    public virtual void Hello()
    {
        Console.Write("Hello, ");
    }
}
class BaseClass : ParentClass
{
    public override void Hello()
    {
        base.Hello();
        Console.WriteLine("World");
    }
}
class Notmain
{
    static void Main()
    {

        BaseClass h = new BaseClass();
        h.Hello();
    }
}