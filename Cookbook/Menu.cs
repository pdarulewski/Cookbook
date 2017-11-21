using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class Menu
    {
        internal Cookbook Cookbook
        {
            get => default(Cookbook.Cookbook);
            set
            {
            }
        }

        public bool addNewRecipe()
        {
            return true;
        }
        public bool removeRecipe()
        {
            return true;
        }
        public bool modifyRecipe()
        {
            return true;
        }

    }
}
