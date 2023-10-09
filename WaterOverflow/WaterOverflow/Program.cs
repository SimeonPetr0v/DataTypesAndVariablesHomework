namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int capacity = 255;
            int l = 0;
            for(int i = 0; i < num; i++)
            {
                int lAdd = int.Parse(Console.ReadLine());
                if(l + lAdd > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else
                {
                    l += lAdd;
                }
            }
            Console.WriteLine(l);
        }
    }
}