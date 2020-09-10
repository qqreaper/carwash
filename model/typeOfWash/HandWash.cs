using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    class HandWash : IWash
    {
        public int Price { get; private set; }

        private const int chemistry = 5;

        private const int water = 5;

        private const int energy = 3;

        private const int time = 10;

        public HandWash()
        {
            Price = 5;
        }

        public void UseResources(Box box)
        {
            box.ChemistryReserve -= chemistry;
            box.EnergyReserve -= energy;
            box.WaterReserve -= water;
        }

        public void GetInfoAboutWash(Box box)
        {
            box.WashingTime = time;
            box.CurrentPrice = Price;
        }
    }
}
