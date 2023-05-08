using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
