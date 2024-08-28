using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class ProductIngredientDOT
    {
        public int ProductID { get; set; }
        public int IngredientID { get; set; }
        public decimal Quantity { get; set; }
    }
}
