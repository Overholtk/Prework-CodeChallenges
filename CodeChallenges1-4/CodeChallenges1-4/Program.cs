﻿using System;

namespace CodeChallenges1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Challenge1();
            Challenge2(1996);
        }

        static void Challenge1()
        {
            string[] arr = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number between 1 and 10:");
                string x = Console.ReadLine();
                arr[i] = x;

            }

            Console.WriteLine("Choose a number from the list: " + arr[0] + arr[1] + arr[2] + arr[3] + arr[4]);
            string sNum = Console.ReadLine();
            int num = Int32.Parse(sNum);
            

            int count = 0;
            //TODO: compare num to each element in arr
            for (int i = 0; i < arr.Length; i++)
            {
                //TODO: count the amount of times num appears in arr
                if (Int32.Parse(arr[i]) == num)
                {
                    count++;
                }
            }
            //TODO: multiply num by appears
            int score = num * count;
            //TODO: output num
            Console.WriteLine(score);
        }

        static void Challenge2(int year)
        {
            bool leap = false;
            int check4 = year % 4;
            int check100 = year % 100;
            int check400 = year % 400;

            if(check4 == 0 & check100 != 0)
            {
                leap = true;
            }
            if(check4 == 0 & check100 == 0 & check400 == 0)
            {
                leap = true;
            }

            if(leap == true)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
} 
