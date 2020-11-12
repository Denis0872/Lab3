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
            if (Day<= 31)
                monthName = "Januaru";
           else if (Day >= 31&&Day <= 59)
                monthName = "February";
            else if(Day >= 59 && Day <= 90)
                monthName = "Marth";
            else if (Day >= 90 && Day <= 121)
                monthName = "Aptil";
            else if (Day >= 121 && Day <= 151)
                monthName = "May";
            else if (Day >= 151 && Day <= 182)
                monthName = "June";
            else if (Day >= 182 && Day <= 212)
                monthName = "July";
            else if (Day >= 212 && Day <= 243)
                monthName = "August";
            else if (Day >= 243 && Day <= 273)
                monthName = "Stptember";
            else if (Day >= 273 && Day <= 304)
                monthName = "October";
            else if (Day >= 304 && Day <= 334)
                monthName = "November";
            else if (Day >= 334 && Day <= 365)
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
