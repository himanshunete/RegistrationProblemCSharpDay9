using System;
using System.Text.RegularExpressions;
using NLog;

namespace NlogLive
{
    class TestRegex
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string[] patternfirstName = { "Himanshu", "Vineet" };
        string[] patternlastName = { "Nete", "Kadwe" };

        public void firstName()
        {
            Regex regex = new Regex(firstNamePattern);
            for (int i = 0; i < patternfirstName.Length; i++)
            {
                var result = regex.Match(patternfirstName[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternfirstName[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternfirstName[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }

        public void lastName()
        {
            Regex regex = new Regex(lastNamePattern);
            for (int i = 0; i < patternlastName.Length; i++)
            {
                var result = regex.Match(patternlastName[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternlastName[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternlastName[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }




        static void Main(string[] args)
        {
            TestRegex regex = new TestRegex();
            regex.firstName();
            Console.WriteLine("**************************");
            regex.lastName();
        }
    }
}
