﻿using System;

namespace HelloApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            Message msg = new Message("Hi");
            Console.WriteLine(msg.Display());
            Console.ReadKey();
        }
    }
}
