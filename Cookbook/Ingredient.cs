using System;

namespace Cookbook
{
    class Ingredient
    {
        private string name { set; get; }
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                if (value != "Fruit" && value != "Vegetable" && value != "Meat" && value != "Seasoning")
                {
                    throw new ArgumentException("The type of ingredient is improper.");
                }

                _type = value;
            }
        }
    }
}
