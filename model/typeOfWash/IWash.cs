using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    interface IWash
    {
        void UseResources(Box box);

        void GetInfoAboutWash(Box box);
    }
}
