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
        string emailPattern = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        string[] patternFirstName = { "Himanshu", "Vineet" };
        string[] patternLastName = { "Nete", "Kadwe" };
        string[] patternEmail = { "himanshuneteh@gmail.com", "kadwe-+vineet@gmail.com" };

        public void firstName()
        {
            Regex regex = new Regex(firstNamePattern);
            for (int i = 0; i < patternFirstName.Length; i++)
            {
                var result = regex.Match(patternFirstName[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternFirstName[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternFirstName[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }

        public void lastName()
        {
            Regex regex = new Regex(lastNamePattern);
            for (int i = 0; i < patternLastName.Length; i++)
            {
                var result = regex.Match(patternLastName[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternLastName[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternLastName[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }

        public void email()
        {
            Regex regex = new Regex(emailPattern);
            for (int i = 0; i < patternEmail.Length; i++)
            {
                var result = regex.Match(patternEmail[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternEmail[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternEmail[i] + " Its not a Valid Pattern ");
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
            Console.WriteLine("**************************");
            regex.email();
        }
    }
}
