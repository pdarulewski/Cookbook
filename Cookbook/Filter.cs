using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class Filter
    {
        public List<Recipe> findRecipeByTag(List<string> tags, List<Recipe> recipes)
        {
            List<Recipe> list = new List<Recipe>();
            List<Recipe> tempList = findRecipeByIngredients(tags, recipes);
            if (list.Equals(null))
            {
                return null;
            }
            else
            {
                foreach (Recipe recipe in tempList)
                {
                    foreach (string tag in tags)
                    {
                        if (recipe.Category.ToLower().Equals(tag.ToLower()) || recipe.Events.ToLower().Equals(tag.ToLower()) || recipe.Type.ToLower().Equals(tag.ToLower()))
                        {
                            list.Add(recipe);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                return list;
            }
        }

        public List<Recipe> findRecipeByTitle(string title, List<Recipe> recipes)
        {
            List<Recipe> list = new List<Recipe>();
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Title.ToLower().Equals(title.ToLower()))
                {
                    list.Add(recipe);
                }
            }
            return list;
        }

        public List<Recipe> findRecipeByIngredients(List<string> ingredients, List<Recipe> recipes)
        {
            List<Recipe> list = new List<Recipe>();
            foreach (Recipe recipe in recipes)
            {
                foreach(Ingredient ingredient1 in recipe.Ingredients)
                {
                    foreach (string ingredient2 in ingredients)
                    {
                        if (ingredient1.Name.ToLower().Equals(ingredient2.ToLower()))
                        {
                            list.Add(recipe);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return list;
        }
    }
}
