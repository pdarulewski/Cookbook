using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cookbook
{
    class Recipe
    {
        private string Title { set; get; }
        private string Description { set; get; }
        private string Text { set; get; }
        private string Category { set; get; }
        private List<Ingredient> Ingredients { set; get; }
        private int Portions { set; get; }
        private TimeSpan CookingTime { set; get; }
        private Image Image { set; get; }
        private int Difficulty
        {
            get
            {
                return Difficulty;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("New value is out of range. Avaiable range is <0, 10>");
                }
                Difficulty = value;
            }
        }

        private List<Enums.Event> events;
        private List<Enums.Category> category;
        private List<Enums.Type> type;

        public Recipe()
        {
        }
        public Recipe(string Title, string Category, string Description,
            string Text, List<Ingredient> Ingredients, int Portions,
            TimeSpan CookingTime, Image Image, int Difficulty)
        {
            this.Title = Title;
            this.Category = Category;
            this.Description = Description;
            this.Text = Text;
            this.Ingredients = Ingredients;
            this.Portions = Portions;
            this.CookingTime = CookingTime;
            this.Image = Image;
            this.Difficulty = Difficulty;
        }

    }
}
