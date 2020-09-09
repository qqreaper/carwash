using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    class AutomaticWash : IWash
    {
        public int Price { get; private set; }

        private const int chemistry = 3;

        private const int water = 10;

        private const int energy = 20;

        private const int time = 5;

        public AutomaticWash()
        {
            Price = 10;
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
