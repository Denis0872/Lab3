using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день от 1 до 365");
            string day = Console.ReadLine();
            int Day = int.Parse(day);
        }
    }
}
