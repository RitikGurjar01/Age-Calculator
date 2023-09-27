using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class AgeCalculator
    {
        public int AgeInYear(DateTime Ct, int by,int bd,int bm)
        {
            int ay = (Ct.Year - by);
           // int rm = (ay * 12) + Ct.Month - (12 - bm - 1);
            Console.WriteLine("your age in years is =" + ay);
            
            return ay;
        }
        public void TakeInput()
        {
            Console.WriteLine(" enter your birth year ");
            int by = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter your birth month ");
            int bm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter your birth date ");
            int bd = Convert.ToInt32(Console.ReadLine());
            DateTime Ct = DateTime.Now;
            AgeInYear(Ct, by,bd,bm);
            AgeInMonth(Ct, by,bm);
            int days=AgeInDays(Ct, by,bm,bd);
            AgeInWeeks(days);
            int hours = AgeInHours(days);
            AgeInMinutes(hours);
            AgeInSeconds(hours);

        }
        public void AgeInMonth(DateTime Ct,int by,int bm)
        {
            int am=(((Ct.Year-by)*12)-bm+1)+Ct.Month;
            
            Console.WriteLine("your age in Months is =" + am);
        }
        public int   AgeInDays(DateTime Ct,int by,int bm,int bd)
        {

            int ad = 0;
            int days = 0;
            for(int i=by;i<=Ct.Year;i++) 
            {
                for(int j=1;j<=12;j++)
                {
                    if (i == by && j <=bm)
                    { 
                        continue; 
                    }
                    if (i==Ct.Year && j >=Ct.Month)
                    {
                        continue;
                    }
                    if(j==1&& j==3 && j==5 && j==7 && j==8 && j==10 && j == 12)
                    {
                        days = days + 31;
                    }
                    else if(j==4 && j== 6  && j==9 && j==11)
                    {
                        days = days + 30;
                    }
                    else
                    {
                        bool isLeap = IsLeapYear(i);
                        if(isLeap)
                        {
                            days = days + 29;
                        }
                        else
                        { 
                            days = days + 28; 
                        }
                    }
                    
                }
                
            }
            int daysInMonth = DaysInMonth(by, bm);
            if (Ct.Year ==by && Ct.Month==bm) 
            {
                
                 ad = days + Ct.Day - bd + 1;
                Console.WriteLine("your age in days is =" + ad);
            }
            else
            {
                 ad = days + Ct.Day + daysInMonth - bd + 1;
                Console.WriteLine("your age in days is =" + ad);
            }
            
            return ad;
        }
        public int DaysInMonth(int year,int month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                bool isLeap = IsLeapYear(year);
                if (isLeap)
                {
                    return  29;
                }
                else
                {
                    return  28;
                }
            }
        }

        public bool IsLeapYear(int year)
        { 
        if ((year%4==0) && (year%400==0) || (year%100!=0))
               return true;
        else
                return false;

        }

        public  void AgeInWeeks(int days)
        {
            int aw = days / 7;
            Console.WriteLine("your age in weeks is =" + aw);
        }
        public int  AgeInHours(int days)
        {
            int AH=days * 24;
            Console.WriteLine("your age in hours is =" + AH);
            return AH;
        }
        public void AgeInMinutes(int hours)
        {
            int AM=hours * 60;
            Console.WriteLine("your age in minutes is =" + AM);
        }
        public void AgeInSeconds( int hours)
        {
         int AS=hours * 60*60;
            Console.WriteLine("your age in seconds is ="+AS);
        }

    }
}