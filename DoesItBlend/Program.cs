using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var m = new Mango();
            var s = new Strawberry();
            var ice = new IceCubes();
            var cell = new CellPhone();

            //Console.WriteLine(b.Blend());
            //Console.WriteLine(m.Blend());
            //Console.WriteLine(s.Blend());

            List<IBlendable> fruits = new List<IBlendable>() { b, m, s, ice, cell };

            foreach(dynamic f in fruits)
            {
                Console.WriteLine(f.Blend());
            }
        }
    }
}
