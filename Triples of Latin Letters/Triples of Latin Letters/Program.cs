namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i < n; i++)
            {
                for(int j = 0;j< n; j++)
                {
                    for(int m = 0;m < n; m++)
                    {
                        char c1 = (char)('a'+i);
                        char c2 = (char)('a' + j);
                        char c3 = (char)('a' + m);
                        Console.WriteLine($"{c1}{c2}{c3}");
                    }
                }
            }
        }
    }
}