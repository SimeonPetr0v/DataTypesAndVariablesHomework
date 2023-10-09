namespace Sum_Of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int totalS = 0;

            for(int i=0;i<n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                totalS+=(int)c;
            }
            Console.WriteLine($"The sum equals: {totalS}");
        }
    }
}