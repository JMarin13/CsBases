using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._04_DependencyInjection
{
    public interface ILabelService
    {
        string GenerateLabel(Product product);
    }
}
