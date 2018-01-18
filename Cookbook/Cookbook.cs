using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cookbook
{
    class Cookbook
    {
        private string name;
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public static List<Recipe> recipes;

        private Image Image;
        public Cookbook()
        {
            CookbookDao dao = new CookbookDao();
            recipes = dao.GetAllRecipes();
        }
        public Cookbook(string Name, List<Recipe> Recipes, Image Image)
        {
            this.Name = Name;
            this.Image = Image;
        }

        public bool AddRecipe(Recipe recipe)
        {
            return true;
        }

        public bool RemoveRecipe(Recipe recipe)
        {
            return true;
        }
    }
}
