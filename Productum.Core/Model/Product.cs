using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productum.Core.Model
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quanitity { get; set; }
        public int ProductCode { get; set; }
    }
}
