﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //static void UseBigInteger()
            {
                Console.WriteLine("=> Use BigInteger:");
                BigInteger biggy =
                BigInteger.Parse("9999999999999999999999999999999999999999999999");
                Console.WriteLine("Value of biggy is {0}", biggy);
                Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
                Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
                BigInteger reallyBig = BigInteger.Parse("8888888888888888888888888888888888888888888");
                BigInteger evenBigger = biggy * reallyBig
                Console.WriteLine("Value of reallyBig is {0}", reallyBig);
                Console.WriteLine("Value of evenBigger is {0}", evenBigger);
                Console.ReadLine();
            }
        }
    }
}
