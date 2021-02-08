using System;
using System.Text.RegularExpressions;
using NLog;

namespace NlogLive
{
    class TestRegex
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Patterns
        /// </summary>
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string emailPattern = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        string mobileNumberPattern = "^[9]{1}[1]{1}[ ][0-9]{10}$";
        string passwordRule4Pattern = "^[A-Z]{1}[a-zA-Z]{7,}([0-9]+)[@#$%^&*+-_]{1}$";

        /// <summary>
        /// Pre-Defined Inputs
        /// </summary>
        string[] patternFirstName = { "Himanshu", "Vineet" };
        string[] patternLastName = { "Nete", "Kadwe" };
        string[] patternMobileNumber = { "91 8803829504", "7378138447" };
        string[] patternPasswordRule4 = { "Himanshunete7@", "Vineetkdwe18##" };
        string[] patternSampleEmail = {"abc@yahoo.com" 
                                            , "abc-100@yahoo.com," 
                                            , "abc.100@yahoo.com"
                                            , "abc111@abc.com,"
                                            , "abc-100@abc.net,"
                                            , "abc.100@abc.com.au"
                                            , "abc@1.com,"
                                            , "abc@gmail.com.com"
                                            , "abc+100@gmail.com"
                                            , "abc"
                                            , "abc@.com.my"
                                            , "abc123@gmail.a"
                                            , "abc123@.com"
                                            , "abc@.com.com"
                                            , ".abc@abc.com"
                                            , "abc()*@gmail.com"
                                            , "abc@%*.com"
                                            , "abc..2002@gmail.com"
                                            , "abc.@gmail.com"
                                            , "abc@abc@gmail.com"
                                            , "abc@gmail.com.1a"
                                            , "abc@gmail.com.aa.au"};

        /// <summary>
        /// Validate First Name
        /// </summary>
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

        /// <summary>
        ///  Validate Last Name
        /// </summary>
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

        /// <summary>
        ///  Validate Email
        /// </summary>
        public void email()
        {
            Regex regex = new Regex(emailPattern);
            for (int i = 0; i < patternSampleEmail.Length; i++)
            {
                var result = regex.Match(patternSampleEmail[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternSampleEmail[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternSampleEmail[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }

        /// <summary>
        ///  Validate Mobile Number
        /// </summary>
        public void mobileNumber()
        {
            Regex regex = new Regex(mobileNumberPattern);
            for (int i = 0; i < patternMobileNumber.Length; i++)
            {
                var result = regex.Match(patternMobileNumber[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternMobileNumber[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternMobileNumber[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }

        /// <summary>
        ///  Validate Password
        /// </summary>
        public void password()
        {
            Regex regex = new Regex(passwordRule4Pattern);
            for (int i = 0; i < patternPasswordRule4.Length; i++)
            {
                var result = regex.Match(patternPasswordRule4[i]);
                if (result.Success)
                {
                    Console.WriteLine(patternPasswordRule4[i] + " Its a Valid Pattern ");
                }
                else
                {
                    Console.WriteLine(patternPasswordRule4[i] + " Its not a Valid Pattern ");
                }
            }
            Logger.Info(" Regex Expression is Successfully Executed ");
        }


        /// <summary>
        /// Call from Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TestRegex regex = new TestRegex();
            regex.firstName();
            Console.WriteLine("**************************");
            regex.lastName();
            Console.WriteLine("**************************");
            regex.email();
            Console.WriteLine("**************************");
            regex.mobileNumber();
            Console.WriteLine("**************************");
            regex.password();
        }
    }
}
