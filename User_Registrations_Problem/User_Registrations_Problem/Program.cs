﻿using System;
using System.Text.RegularExpressions;

namespace User_Registrations_Problem
{
    class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_User_Registration_Problem");
            FirstNameVal();
        }
        public static void FirstNameVal()
        {
            Regex rg = new Regex(REGEX_PATTERN);
            Console.Write("Enter First Name: ");
            string first_name = Console.ReadLine();
            bool validate = rg.IsMatch(first_name);
            if (validate)
                Console.WriteLine("Name is Valid : " + first_name);
            else
                Console.WriteLine("Invalid FirstName");

        }
    }
}
