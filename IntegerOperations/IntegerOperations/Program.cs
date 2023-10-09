using System.Numerics;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger num3 = BigInteger.Parse(Console.ReadLine());
            BigInteger num4 = BigInteger.Parse(Console.ReadLine());
            BigInteger sum1 = num1 + num2;
            BigInteger sum2 = sum1 / num3;
            BigInteger sum3 = sum2 * num4;
            Console.WriteLine(sum3);

        }
    }
}