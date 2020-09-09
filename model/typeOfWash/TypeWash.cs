using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model.typeOfWash
{
    class TypeWash
    {
        private IWash wash;

        public void SetTypeWash(IWash wash)
        {
            this.wash = wash;
        }

        public void DoWash(Box box)
        {
            if (wash != null)
                wash.UseResources(box);
        }
    }
}
