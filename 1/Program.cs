namespace _task1
    ;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enter your name");
        Console.ReadLine();
        int a, b, i, sum = 0;
        for (i = 1; i < 100; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                sum = sum + i;


            }


        } Console.WriteLine("\nThe sum of all the multiples of 3 or 5 Below 100: {0}", sum);
        Console.Read();

    }
}
