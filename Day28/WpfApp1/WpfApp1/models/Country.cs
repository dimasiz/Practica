using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    public class Country
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public double Population { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"---->Country is{Name}")
                .AppendLine($"\t area is {Area}km2")
                .AppendLine($"\tpopulation is{Population} millions people")
                .ToString();
        }
    }
}
