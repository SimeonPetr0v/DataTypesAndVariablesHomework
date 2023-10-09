namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            while (n != 0)
            {
                int d = n % 10;
                sum += d;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}