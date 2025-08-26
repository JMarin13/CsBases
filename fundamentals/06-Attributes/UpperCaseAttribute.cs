using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._06_UpperCaseAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UpperCaseAttribute : Attribute
    {
    }

    public static class AttributeProcesor
    {
        public static void ApplyUpperCase(object obj)
        {
            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(string) && Attribute.IsDefined(prop, typeof(UpperCaseAttribute)))
                {
                    var value = prop.GetValue(obj) as string;

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        prop.SetValue(obj, value.ToUpper());
                    }
                }
            }
        }
    }
}
