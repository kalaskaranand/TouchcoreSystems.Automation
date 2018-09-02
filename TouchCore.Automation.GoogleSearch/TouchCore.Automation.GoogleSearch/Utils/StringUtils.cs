using System;
using System.Linq;

namespace TouchCore.Automation.GoogleSearch
{
    public class StringUtils
    {
        // Method Name : Get_Random_String
        // Use : This Method is used to get a random alpha string of specified length
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public static string Get_Random_String(int length)
        {
            try
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return null;
        }

        // Method Name : Get_Random_AlphaNumeric_String
        // Use : This Method is used to get a random alphanumeric string of specified length
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public static string Get_Random_AlphaNumeric_String(int length)
        {
            try
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return null;
        }

    }
}
