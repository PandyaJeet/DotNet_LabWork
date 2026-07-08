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
    static void triangle()
    {
        Console.WriteLine("Enter number of rows : ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}