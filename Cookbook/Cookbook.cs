using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cookbook
{
    class Cookbook
    {
        private string Name { set; get; }
        private List<Recipe> Recipes { set; get; }
        private Image Image { set; get; }

        internal Recipe Recipe
        {
            get => default(Cookbook.Recipe);
            set
            {
            }
        }

        public Cookbook() { }
        public Cookbook(string Name, List<Recipe> Recipes, Image Image)
        {
            this.Name = Name;
            this.Recipes = Recipes;
            this.Image = Image;
        }

        public bool addRecipe(Recipe recipe)
        {
            return true;
        }

        public bool removeRecipe(Recipe recipe)
        {
            return true;
        }
    }
}
