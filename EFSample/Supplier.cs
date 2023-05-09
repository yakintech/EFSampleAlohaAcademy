using EFSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    public class Supplier : BaseModel
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
