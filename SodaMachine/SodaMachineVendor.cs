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
            userCoinPurse = new List<Coin>();

            // put money into machine

            // pick a drink
            DrinkChoice();

            // either get drink(get change...maybe) or dont get drink(get money back)

        }

        public void DrinkChoice()
        {
            double CoinPurseTotal = 0;
            double changeDifference = 0;
            Console.WriteLine("What soda do you want?");
            sodaChoice = Console.ReadLine();

            if (sodaChoice.Equals("Orange"))
            {
                // scan through user coinpurse and get total
                for (int i = 0; i < userCoinPurse.Count; i++)
                {
                    CoinPurseTotal += userCoinPurse[i].value; //adding coinPurseTotal to the following objects in the userCoinPurse, for however many coins are in the purse.
                }
                // is total enough for soda?
                if (CoinPurseTotal >= sr.orangePrice)
                {
                    // subtract price from coinPurseTotal, and see if you can make change.
                    // coinPurse = .75
                    // .75 - .60 = .15
                    // changeNeeded = .15

                    // is there enough change in the CoinRegister object to make change
                    // is changeNeeded >= .25, if yes see if we have a quarter, if not move on to next coin type
                    // is changeNeeded >= .25, if yes see if we have dimes, do we have 2 of them?, if not move on to next coin type



                    // is there enough change in machine?


                    sr.orangeCount--;
                }
                
                
            }
            else if (sodaChoice.Equals("Grape"))
            {
                sr.grapeCount--;
            }
            else if (sodaChoice.Equals("Lemon"))
            {
                sr.lemonCount--;
            }
            else
            {
                Console.WriteLine("Sorry please pick from Orange, Grape or Lemon.");
            }
                            
            
        }

        public void Payment(List<Coin> coins)
        {
            
        }

        public void PayingInQuarters() //methods for user putting in the amount of money
        {
            Console.WriteLine("How many quarters are you putting in?");
            usersQuarter = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersQuarter; i++) //loop will run for however many times the userInputs, in such will add that many objects.
            {
                Quarter q = new Quarter();
                userCoinPurse.Add(q);
            }
        }

        public void PayingInDimes()
        {
            Console.WriteLine("How many dimes are you putting in?");
            usersDime = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersDime; i++)
            {
                Dime d = new Dime();
                userCoinPurse.Add(d);
            }
        }

        public void PayingInNickels()
        {
            Console.WriteLine("How many nickels are you putting in?");
            usersNickel = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersNickel; i++)
            {
                Nickel n = new Nickel();
                userCoinPurse.Add(n);
            }
        }
        public void PayInPennies()
        {
            Console.WriteLine("How many pennies are you putting in?");
            usersPenny = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersPenny; i++) 
            {
                Penny p = new Penny();
                userCoinPurse.Add(p);
            }
        }

    }
}
