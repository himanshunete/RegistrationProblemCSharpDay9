using System;
using System.Text.RegularExpressions;
using NLog;

namespace NlogLive
{
    class TestRegex
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string[] patternfirstName = { "Himanshu", "Vineet" };

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


        static void Main(string[] args)
        {
            TestRegex regex = new TestRegex();
            regex.firstName();
            Console.WriteLine("**************************");
        }
    }
}
