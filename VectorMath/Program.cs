using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2, 8, 6);

            Console.WriteLine("adding two vectors");
            Console.WriteLine($"with a static method: {Vector3.Add(one, two)}");
            Console.WriteLine($"With operator overloading: {one + two}");
            Console.WriteLine($"Vector scaling : {10 * one}");
            Vector3 three = new Vector3(4, 5, 6);
            Console.WriteLine($"Vector Comparison: {one == three}");

            if (one)
            {
                Console.WriteLine("Vector one is not zero");
            }
            else
            {
                Console.WriteLine("Vector one is zero");
            }
        }
    }
}
