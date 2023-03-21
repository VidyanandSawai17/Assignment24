using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    // Delegate - Delegate is a reference type in C#
    //            Delegate will hold the method reference
    //            Method signature should be match with delegate signature 
    //            Signature - return type and parameter list should be same


    public delegate void MyDelegate(); // Delegate

    public class bank
    {

        // Event - Action raised by the user in programming is called an action

        public event MyDelegate NoBal; // Event
        public event MyDelegate LowBal;


        private double bal;
        public bank(double initalBal)
        {
            bal = initalBal;
            Console.WriteLine("Initial bal :" + bal);

        }

        public void Credit(double amt)
        {
            bal += amt;
            Console.WriteLine("Credited" + amt + "to account and new bal :" + bal);
        }
        public void Debit(double amt)
        {
            if (amt > bal)
            {
                NoBal();
            }
            else if (bal - amt < 3000)
            {
                LowBal();
            }
        }

    }
    public class Program
    {

        static void message1()
        {
            Console.WriteLine("No Bal");
        }

        static void message2()
        {
            Console.WriteLine("Low Bal");
        }

        static void Main(string[] args)
        {


            bank b1 = new bank(0);
            b1.NoBal += new MyDelegate(message1);
            b1.LowBal += new MyDelegate(message2);

            b1.Credit(3000);
          
            b1.Debit(3000);


        }
    }

}
