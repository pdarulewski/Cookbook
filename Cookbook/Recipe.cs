using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cookbook
{
    class Recipe
    {
        private string title;
        public string Title
        {
            set
            {
                this.title = value;
            }

            get
            {
                return this.title;
            }
        }
        private string description;
        public string Description
        {
            set
            {
                this.description = value;
            }

            get
            {
                return this.description;
            }
        }
        private string text;
        public string Text
        {
            set
            {
                this.text = value;
            }

            get
            {
                return this.text;
            }
        }
        private List<Ingredient> ingredients;
        public List<Ingredient> Ingredients
        {
            set
            {
                this.ingredients = value;
            }

            get
            {
                return this.ingredients;
            }
        }
        private int portions;
        public int Portions
        {
            set
            {
                this.portions = value;
            }

            get
            {
                return this.portions;
            }
        }
        private TimeSpan cookingTime;
        public TimeSpan CookingTime
        {
            set
            {
                this.cookingTime = value;
            }

            get
            {
                return this.cookingTime;
            }
        }
        private Image image;
        public Image Image
        {
            set
            {
                this.image = value;
            }

            get
            {
                return this.image;
            }
        }
        private int difficulty;
        public int Difficulty
        {
            set
            {
                this.difficulty = value;
            }

            get
            {
                return this.difficulty;
            }
        }
        private string events;
        public string Events
        {
            set
            {
                this.events = value;
            }

            get
            {
                return this.events;
            }
        }
        private string category;
        public string Category
        {
            set
            {
                this.category = value;
            }

            get
            {
                return this.category;
            }
        }
        private string type;
        public string Type
        {
            set
            {
                this.type = value;
            }

            get
            {
                return this.type;
            }
        }

        public Recipe()
        {

        }

        public Recipe(string Title, string Description,
                      string Text, List<Ingredient> Ingredients, int Portions,
                      TimeSpan CookingTime, Image Image, int Difficulty, 
                      string Events, string Category, string Type)
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
            this.Events = Events;
            this.Type = Type;
        }
    }
}
