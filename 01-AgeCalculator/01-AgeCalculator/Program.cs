using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                bool enterNewData = false;
                while (enterNewData == false)
                {
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
                    int daysResults = todayMonth - birthMonth;


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

                    double reminingDaysinweeks = Math.Floor(daysInMonth28 % 7);
                    double daysResults3 = reminingDaysinweeks + daysFromDays;
                    double weeksInMonths = Math.Floor((daysInMonth28) / 7 + weeksFromDays);

                    bool exitCurrentSession = false;
                    while (exitCurrentSession == false) {


                        for (int i = 0; i < 5; i++) {

                            Console.Clear();

                            Console.WriteLine("You are " + yearResults + " years, " + weeksInMonths + " weeks and " + daysResults3 + " days old " + DateTime.Now.Hour + " Hours " + DateTime.Now.Minute + " Min " + DateTime.Now.Second + " Sec ");
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("Press e if you want to exit, Press c to continue see you age increasing, and press i to enter new valuse");
                        string exitInput = Console.ReadLine();
                        if (exitInput == "e") {
                            exitCurrentSession = true;
                            enterNewData = true;}
                        else if (exitInput == "c") { exitCurrentSession = false; }
                        else { exitCurrentSession = true;
                            enterNewData = false; };

                    }
                }
            }

            catch (Exception e)
            { Console.WriteLine("You entered some thing wrong " + e.Message); Console.ReadLine(); };

        }
    
    }
}