using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals
{
    public interface IProduct
    {
        void ApplyDiscount(double percentaje);
        string GetDescription();
    }
}
