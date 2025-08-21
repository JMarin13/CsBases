using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals
{
    public class ServiceProduct : Product
    {
        public int DurationInDays { get; set; }

        public ServiceProduct(string name, double price, int durationInDays) : base(name, price)
        {
            DurationInDays = durationInDays;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} - Duration: {DurationInDays} days";
        }
    }
}
