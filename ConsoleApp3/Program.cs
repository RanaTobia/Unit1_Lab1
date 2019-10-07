using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)



        {
            // reading 3 numbers from the console and convert it to double


            Console.WriteLine("Enter Your First Dollar Amount");
            double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(x);
            Console.WriteLine("Enter Your Secound Dollar Amount");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Third Dollar Amount");
            double z = Convert.ToDouble(Console.ReadLine());



            // find the total amount
            double total = x + y + z;
            Console.WriteLine(" The total Dollar Amount is :" + total);



            // find the average amount
            double average = total / 3;
            Console.WriteLine(" The Average Dollar Amount is :" + average);


            // Find the highest amount

            double highest = (Math.Max(Math.Max(x, y), z));
            Console.WriteLine(" The Highest Amount is  :" + highest);


            // Find the Lower amount 

            double lowest = (Math.Min(Math.Min(x, y), z));
            Console.WriteLine(" The Lowest Amount is  :" + lowest);



            // Format the output to a diffrent cultures 

            Console.WriteLine(" Dispalying the Total Amount in US Currency : " + total.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(" Dispalying the Total Amount in Swedish Currency : " + total.ToString("C", new CultureInfo("sv-SE")));
            Console.WriteLine(" Dispalying the Total Amount in Japanese Currency: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine(" Dispalying the Total Amount in Thailand Currency : " + total.ToString("C", new CultureInfo("th-TH")));





        }
    }
}

