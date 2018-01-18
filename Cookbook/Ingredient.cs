using System;

namespace Cookbook
{
    class Ingredient
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
                return this.name;
            }
        }
        private int amount;
        public int Amount
        {
            set
            {
                this.amount = value;
            }

            get
            {
                return this.amount;
            }
        }
        private string unit;
        public string Unit
        {
            set
            {
                this.unit = value;
            }

            get
            {
                return this.unit;
            }
        }

        public Ingredient(string Name, int Amount, string Unit)
        {
            this.Name = Name;
            this.Amount = Amount;
            this.Unit = Unit;
        }

        public Ingredient(string Name)
        {
            this.Name = Name;
            this.Amount = 0;
            this.Unit = "kg";
        }
    }
}
