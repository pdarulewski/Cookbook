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
