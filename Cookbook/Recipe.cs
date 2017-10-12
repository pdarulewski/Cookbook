using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class Recipe
    {
        private string title { set; get; }
        private string recipeText { set; get; }
        private Dictionary<Ingredient, String> ingredientList { set; get; }
        //Type of ingredient and its amount (e.g. "1", "2" but also "spoon", "glass" etc.)
        private int portions { set; get; }
        private TimeSpan cookingTime { set; get; }
        private int _difficulty;
        public int Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException("New value is out of range. Avaiable range is <0, 10>");
                _difficulty = value;
            }
        }

    }
}
