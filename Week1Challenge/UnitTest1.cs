using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NamaAndAge()
        {
            string firstName = "Tulha";
            string lastName = " Alsalah";
            int age = 41;
            Console.WriteLine(age+7);
            Console.WriteLine(age-7);
            Console.WriteLine(age*7);
            Console.WriteLine(age/7);
            Console.WriteLine(age%7);

        }
        [TestMethod]
        public void ArrayBooks()
        {
            string[] books = { "Outliers", "The Majic of Thinking Big", "Think like a Monk ", "Dare to Lead" };
            
        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 11, 17));
            listOfDates.Add(new DateTime(2020, 12, 5));
            listOfDates.Add(new DateTime(2020, 8, 4));

        }
        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 8;
            if (hours >= 10)
            {
                Console.WriteLine("WoW, That's alot of Sleep");
            }
            else if (hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine(" Oh man, get some sleep!");
            }
           
        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine( "Good Day");
                    break;
                case "Okay":
                    Console.WriteLine("Okay day so far");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow ");
                    break;
                case ":(":
                    Console.WriteLine("Let us be positive");
                    break;
                default:
                    Console.WriteLine("Please enter from above");
                    break;

            }

        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach(char letter in name)
                {
                if (letter == 'i')
                {


                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not a i");
                }
            }

        } 
    }
}
