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
                    Console.Write("Please enter the year: ");
                    string line = Console.ReadLine();
                    int yearNum = int.Parse(line);
                bool isLeapYear = (yearNum % 4 == 0);

                    if (isLeapYear)
                    {
                        Console.WriteLine(" IS a leap year");
                    }
                    else
                    {
                        Console.WriteLine(" is NOT a leap year");
                    }
                    int maxDayNum = isLeapYear ? 366 : 365;

                    ArrayList DaysInMonths = new ArrayList() { 31, 28, 31, 30, 31, 31, 31, 30, 31, 30, 30, 31 };
                    ArrayList DaysInMonthsLeap = new ArrayList() { 31, 29, 31, 30, 31, 31, 31, 30, 31, 30, 30, 31 };
                    Console.WriteLine("Введите день от 1 до 365 или 366 если год високосный");
                    string day = Console.ReadLine();
                    int Day = int.Parse(day);
                    if (Day < 1 || Day > maxDayNum)
                    {
                    throw new ArgumentOutOfRangeException("Day out of range");
                    }
                    int MonthNam = 0;
                     if(isLeapYear)
                    foreach (int daysInMonth in DaysInMonthsLeap)
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
                     else
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
