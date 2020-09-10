using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    class Self_serviceWash : IWash
    {
        public int Price { private set; get; }

        private const int chemistry = 5;

        private const int water = 6;

        private const int energy = 3;

        private const int time = 15;

        public Self_serviceWash()
        {
            Price = 3;
        }

        public void UseResources(Box box)
        {
            box.ChemistryReserve -= chemistry;
            box.EnergyReserve -= energy;
            box.WaterReserve -= water;
        }

        public void GetInfoAboutWash(Box box)
        {
            box.CurrentPrice = Price;
            box.WashingTime = time;
        }
    }
}
