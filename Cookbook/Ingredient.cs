using System;

namespace Cookbook
{
    class Ingredient
    {
        private string Name { set; get; }
        private int Amount { set; get; }
        private string Unit { set; get; }

        public override string ToString()
        {
            return string.Format("{0} {1} of {2}.", Amount, Unit, Name);
        }

        public Ingredient(string Name)
        {
            this.Name = Name;
            this.Amount = 0;
            this.Unit = "kg";
        }

    }
}
