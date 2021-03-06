﻿/*
 * ITSE 1430
 * Your Name
 */
using System;

namespace Section1
{
    class Program
    {
        static void Main ( string[] args )
        {
            //PlayingWithVariables();                       
            AddMovie();
        }

        static void AddMovie ()
        {
            string title = ReadString("Enter a title: ", true);

            int releaseYear = ReadInt32("Enter the release year (>= 0): ", 0, 2100);
            int runLength = ReadInt32("Enter the run length (>= 0): ", 0, 86400);

            string description = ReadString("Enter a description: ", false);
            bool isClassic = ReadBoolean("Is this a classic movie?");
        }

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message + " (Y/N)");

            do
            {
                string value = Console.ReadLine();

                //Check for empty string
                // 1. if (value != "")
                // 2. if (value != String.Empty)
                // 3. if (value != null && value.Length == 0)
                if (!String.IsNullOrEmpty(value))
                {
                    // Input validation
                    // 1. If
                    // 2. Switch
                    // 3. String casing
                    // 4. String comparison
                    //value = value.ToLower();
                    //if (value == "y")
                    //    return true;
                    //else if (value == "n")
                    //    return false;

                    //bool isYes = String.Compare(value, "Y", true) == 0 ? true : false;

                    if (String.Compare(value, "Y", true) == 0)
                        return true;
                    else if (String.Compare(value, "N", true) == 0)
                        return false;

                    char firstChar = value[0];
                    //if (firstChar == 'Y' || firstChar == 'y')
                    //    return true;
                    //else if (firstChar == 'N' || firstChar == 'n')
                    //    return false;                    
                    //switch (firstChar)
                    //{
                    //    #region Demo case
                    //    //case 'A':
                    //    //{
                    //    //    Console.WriteLine("A");
                    //    //    break;
                    //    //};
                    //    //case 'a': Console.WriteLine("a"); break;
                    //    #endregion

                    //    case 'Y':
                    //    case 'y': return true;

                    //    case 'N': 
                    //    case 'n': return false;
                    //};
                };

                Console.WriteLine("Enter Y/N");
            } while (true);
        }

        private static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            do
            {
                //var x = 10;
                string value = Console.ReadLine();

                //If required and string is empty then error
                if (!String.IsNullOrEmpty(value) || !required)
                    return value;

                if (required)
                    Console.WriteLine("Value is required");
            } while (true);
        }

        private static int ReadInt32 ( string message, int minValue, int maxValue )
        {
            Console.Write(message);

            do
            {
                //string temp = Console.ReadLine();
                var temp = Console.ReadLine();
                //int value = Int32.Parse(temp);

                //TODO: Clean this up
                //int value;
                if (Int32.TryParse(temp, out var value))
                {
                    if (value >= minValue && value <= maxValue)
                        return value;
                };

                Console.WriteLine("Value must be between minValue and maxValue");
            } while (true);
        }

        private static void PlayingWithVariables ()
        {
            Console.WriteLine("Hello World!");

            int hours;
            double payRate;

            {
                string name;
                bool pass;
            }

            {
                int name = 10;
            }

            //Not cased properly
            //string FirstName;

            //hours = 10;
            //int newHours = hours;

            //Logical block 1     
            int hours2 = 10;
            //int hours3;
            //hours3 = 3;

            int x, y, z;
            int a = 10, b = 20, c = 30;

            //Display a message
            Console.WriteLine("Enter a value");
            string input = Console.ReadLine();
        }
    }
}
