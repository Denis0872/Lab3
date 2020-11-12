using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay
{
    class Program
    {
        static string monthName;
        //static int Day;
        static string MetodMonth()
        {
            Console.WriteLine("Введите день от 1 до 365");
            string day = Console.ReadLine();
            int Day = int.Parse(day);
            if (Day>=0&&Day<= 31)
                monthName = "Januaru";
            if (Day <= 59)
                monthName = "February";
            if (Day <= 90)
                monthName = "Marth";
            if (Day <= 121)
                monthName = "Aptil";
            if (Day <= 151)
                monthName = "May";
            if (Day <= 182)
                monthName = "June";
            if (Day <= 212)
                monthName = "July";
            if (Day <= 243)
                monthName = "August";
            if (Day <= 273)
                monthName = "Stptember";
            if (Day <= 304)
                monthName = "October";
            if (Day <= 334)
                monthName = "November";
            if (Day <= 365)
                monthName = "December";
            else
            {
                monthName = "Такого месяца не существует";
            }
            return monthName;
            
        }
        static void Main(string[] args)
                    {
                        MetodMonth();
                        Console.WriteLine("{0}", monthName);
                        Console.ReadKey();
                    }

    }
}
