﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models
{
    public class City : BaseModel
    {

        public override string ToString()
        {
            return Name;
        }
        public string Name { get; set; }
    }
}
