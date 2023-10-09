namespace Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fIndex = int.Parse(Console.ReadLine());
            int lIndex = int.Parse(Console.ReadLine());

            for(int i = fIndex; i <= lIndex; i++)
            {
                char c = (char)i;
                Console.Write(c + "");
            }
        }
    }
}