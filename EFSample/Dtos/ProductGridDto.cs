using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Dtos
{
    public class ProductGridDto
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double TaxPrice { get; set; }
        public double UnitsInStock { get; set; }

    }
}
