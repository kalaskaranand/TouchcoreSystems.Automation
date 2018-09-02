using System;
using System.Linq;

namespace TouchCore.Automation.GoogleSearch
{
    public class NumberUtils
    {
        // Method Name : Get_Random_Number
        // Use : This Method is used to get a random number of specified length
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public static double Get_Random_Number(int length)
        {
            try
            {
                Random random = new Random();
                const string chars = "0123456789";
                string randonNumberString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
                return double.Parse(randonNumberString);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return 0;
        }

        // Method Name : Get_Random_Number
        // Use : This Method is used to get a random number between specified limits
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public static double Get_Random_Number(int minNumber, int maxNumber)
        {
            try
            {
                Random rand = new Random();
                double randonNumber = rand.Next(minNumber, maxNumber);
                return randonNumber;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return 0;
        }
         
    }
}
