using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class CoinRegister
    {
       public List<Quarter> QuarterHolder;
       public List<Dime> DimeHolder;
       public List<Nickel> NickelHolder;
       public List<Penny> PennyHolder;

        public CoinRegister()
        {
            QuarterHolder = new List<Quarter>();
            DimeHolder = new List<Dime>();
            NickelHolder = new List<Nickel>();
            PennyHolder = new List<Penny>();
            AddQuarters();
            AddDimes();
            AddNickels();
            AddPennys();
        }

        public void AddQuarters()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter addQuarters = new Quarter();
                QuarterHolder.Add(addQuarters);
            }
        }

        public void AddDimes()
        {
            for (int i = 0; i < 10; i++)
            {
                Dime addDimes = new Dime();
                DimeHolder.Add(addDimes);
            }
        }

        public void AddNickels()
        {
            for (int i = 0; i < 20; i++)
            {
                Nickel addNickels = new Nickel();
                NickelHolder.Add(addNickels);
            }
        }

        public void AddPennys()
        {
            for (int i = 0; i < 50; i++)
            {
                Penny addPennys = new Penny();
                PennyHolder.Add(addPennys);
            }
        }
    }
}
