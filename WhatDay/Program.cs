using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay
{
    class Program
    {
        enum MonthName {Januaru,February, Marth, Aptil,May,June,July,August,September, October,November,December };

        //static int Day;

            #region old code
            /*  if (Day<= 31)
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
              return monthName;*/
            #endregion
        
        static void Main(string[] args)
        {
            try { 
                    ArrayList DaysInMonths = new ArrayList() { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
                    Console.WriteLine("Введите день от 1 до 365");
                    string day = Console.ReadLine();
                    int Day = int.Parse(day);
                    if (Day < 1 || Day > 365)
                    {
                    throw new ArgumentOutOfRangeException("Day out of range");
                    }
                    int MonthNam = 0;
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (Day <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            Day -= daysInMonth;
                            MonthNam++;
                        }
                    }
                    MonthName temp = (MonthName)MonthNam;
                    string MonthName = temp.ToString();

                    Console.WriteLine("{0} {1}", Day, MonthName);
                }
            catch (Exception caught)
                {
                    Console.WriteLine(caught);
                }

            Console.ReadKey();
         }

    }
}
