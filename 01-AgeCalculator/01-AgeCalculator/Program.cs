using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("What is your birthday ? (Enter date in format MM/DD/YYYY): ");
                String inPut = Console.ReadLine();
                DateTime inPut2 = DateTime.Parse(inPut);
                DateTime Now = DateTime.Now;
                int birthYear = inPut2.Year;
                int todayYear = Now.Year;
                int yearResults = todayYear - birthYear;


                int birthMonth = inPut2.Month;
                int todayMonth = DateTime.Now.Month;
                int monthResults = todayMonth - birthMonth;

                int birthDay = inPut2.Day;
                int todayDay = DateTime.Now.Day;
                int daysResults = todayMonth -birthMonth;


                if (birthMonth > todayMonth)
                {
                    monthResults = 12 - (birthMonth - todayMonth);
                    yearResults = yearResults - 1;
                }
                else
                {
                    monthResults = todayMonth - birthMonth;
                };



                if (birthDay > todayDay)
                {
                    daysResults = 30 - (birthDay - todayDay);
                    monthResults = monthResults - 1;
                }
                else
                {
                    daysResults = todayDay - birthDay;
                };



                int weeksFromDays = daysResults / 7;
                int daysFromDays = daysResults % 7;

               



               double daysInMonths = monthResults * 30.41;
               double leepDays = yearResults / 4;
               double daysInMonth28 = daysInMonths + leepDays;

               double reminingDaysinweeks = Math.Floor (daysInMonth28 % 7);
               double daysResults3 = reminingDaysinweeks + daysFromDays;
               double weeksInMonths = Math.Floor((daysInMonth28)/ 7+ weeksFromDays);





                Console.WriteLine("You are " + yearResults + " years, " + weeksInMonths + " weeks and " + daysResults3 + " days old");
                String inPut3 = Console.ReadLine();


            }

            catch (Exception e)
            { Console.WriteLine("You entered some thing wrong "+ e.Message); Console.ReadLine(); };





        }
    
    }
}
