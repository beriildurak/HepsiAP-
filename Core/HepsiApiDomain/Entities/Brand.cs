using HepsiApiDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApiDomain.Entities
{
    public class Brand:EntityBase,IEntityBase
    {
        public Brand() { }
        public Brand(string name) {
            Name = name;
        }
        public required string Name { get; set; }

    }
}
