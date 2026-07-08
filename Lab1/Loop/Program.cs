using System.Runtime.Versioning;

class Hello
{
    static void loop()
    {
        Console.Write("Start Value : ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("End Value : ");
        int end = Convert.ToInt32(Console.ReadLine());
        for(int i = start ; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Main()
    {
        Hello.loop();
    }
}