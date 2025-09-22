namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintSum();
        }

        private static int AddNumbers(int a, int b)
        { 
        
            return a + b;

        }

        private static void PrintSum()
        {
            int sum = AddNumbers(5, 10);
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
