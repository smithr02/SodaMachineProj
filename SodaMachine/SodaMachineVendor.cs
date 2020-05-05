using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachineVendor //where all the logic is brought together
    {
        public SodaRegister sr;
        public CoinRegister cr;
        public string sodaChoice;
        public int usersQuarter;
        public int usersDime;
        public int usersNickel;
        public int usersPenny;
        public List<Coin> userCoinPurse;
        public SodaMachineVendor()
        {
            sr = new SodaRegister(10,15,20); // here we can dynamically change the amount of soda cans of each type we want
            cr = new CoinRegister();

        }

        public void Transaction()
        {
            userCoinPurse = new List<Coin>();
            Console.WriteLine("What soda do you want?");
            sodaChoice = Console.ReadLine();
                            
            for(int i=0; i < usersQuarter; i++)
            {
                Quarter q = new Quarter();
                userCoinPurse.Add(q);
            }
        }

        public void Payment(List<Coin> coins)
        {
            
        }

        public void PayingInQuarters() //methods for user putting in the amount of money
        {
            Console.WriteLine("How many quarters are you putting in?");
            usersQuarter = int.Parse(Console.ReadLine());
        }

        public void PayingInDimes()
        {
            Console.WriteLine("How many dimes are you putting in?");
            usersDime = int.Parse(Console.ReadLine());
        }

        public void PayingInNickels()
        {
            Console.WriteLine("How many nickels are you putting in?");
            usersNickel = int.Parse(Console.ReadLine());
        }
        public void PayInPennies()
        {
            Console.WriteLine("How many pennies are you putting in?");
            usersPenny = int.Parse(Console.ReadLine());
        }

    }
}
