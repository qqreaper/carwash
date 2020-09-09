using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    class DryWash : IWash
    {
        public int Price { get; private set; }

        private const int chemistry = 12;

        private const int energy = 5;

        private const int time = 7;

        public DryWash()
        {
            Price = 12;
        }

        public void UseResources(Box box)
        {
            box.ChemistryReserve -= chemistry;
            box.EnergyReserve -= energy;
        }

        public void GetInfoAboutWash(Box box)
        {
            box.WashingTime = time;
            box.CurrentPrice = Price;
        }
    }
}
