﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first your name: ");

            string  FirstName = Console.ReadLine();

            Console.WriteLine("Please enter last your name: ");

            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", FirstName, LastName);

            //Console.WriteLine("Hello " + UserName);
        }
    }
}
