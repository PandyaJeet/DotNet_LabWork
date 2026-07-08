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
        Hello.pyramid();
    }
    static void triangle()
    {
        Console.Write("Enter number of rows : ");
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
    static void inversetriangle()
    {
        Console.Write("Enter number of rows : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int space = n;
        for (int i = 0; i <= n; i++)
        {
            for (int k = space; k >= 1; k--)
            {
                Console.Write(' ');
            }
            space--;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            
        }
    }
    static void pyramid()
    {
        Console.Write("Enter number of rows : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int space = n;
        for (int i = 0; i < n; i++)
        {
            for (int k = space; k >= 1; k--)
            {
                Console.Write(' ');
            }
            space--;
                for (int j = 0; j <= i*2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            
        }
    }
}