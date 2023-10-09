namespace StorageKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string maxModel = "";
            double maxVolume = double.MinValue;

            for(int i= 0;i<num;i++)
            {
                string m=Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double v = Math.PI * Math.Pow(r, 2) * h;

                if (v > maxVolume)
                {
                    maxVolume = v;
                    maxModel = m;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}