﻿using Core;
using System;

namespace ConsoleApplication1
{
    class Program
    {       
        static void Main(string[] args)
        {
            var registry = new Factory<ConcreteTXT>().Get().GetProfessors();
            foreach (var item in registry)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
}
