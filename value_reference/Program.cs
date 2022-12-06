using System;

namespace value_reference
{
    class Program
    {
        //static void func(int[] array)
        //{
        //    array[0] = 888;
        //    array = new int[3];
        //    array[0] = 999;
        //}
        static void func(int[] v)
        {
            v[0] = 888;
            v = new int[3];
            v[0] = 999;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };
            func(array);
            Console.WriteLine(array[0]);
        }
    }
}
