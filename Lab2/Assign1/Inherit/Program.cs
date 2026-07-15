class ParentClass()
{
    protected int n1, n2;
}
class DerivedClass : ParentClass
{
    static void Main()
    {   
        DerivedClass o = new DerivedClass();
        Console.WriteLine(o.n1 + o.n2);
    }
}