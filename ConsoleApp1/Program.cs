namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }
    }
}