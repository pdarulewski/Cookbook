using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class CookbookDao
    {
        internal Cookbook Cookbook
        {
            get => default(Cookbook.Cookbook);
            set
            {
            }
        }

        public List<Recipe> getAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            return recipes;
        }

        public bool addRecipe(Recipe recipe)
        {
            return true;
        }

        public bool updateRecipe(Recipe recipe)
        {
            return true;
        }

        public bool removeRecipe(Recipe recipe)
        {
            return true;
        }


    }
}
