using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset
{
    class Asset
    {
        private decimal value;
        private decimal depreciation;

        private string Name { get; set; }

        public Asset(string name, decimal value, decimal depreciation)
        {
            Name = name;
            this.value = value;
            this.depreciation = depreciation;
        }

        public decimal Value
        {
            get
            {
                return value;
            }
            set
            {
                if(value > 0)
                {
                    this.value = value;
                }
            }
        }
        public decimal Depreciation
        {
            get
            {
                return depreciation;
            }
            set
            {
                if (value > 0)
                {
                    depreciation = value;
                }
            }
        }
        public void ChangeValue(int amount)
        {
            Value =+ Value / 100 * amount;
        }

        public decimal DepreciationAmount()
        {
            return Value / 100 * Depreciation;
        }

        public decimal DepreciatedValue()
        {
            return Value - DepreciationAmount();
        }
    }
}
