using System;

namespace value_reference_1
{
    class Program
    {
    
        static void func(ref int[] array)
        {
            array[0] = 888;
            array = new int[3];
            array[0] = 999;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };
            func(ref array);
            Console.WriteLine(array[0]);
        }
    }
}
