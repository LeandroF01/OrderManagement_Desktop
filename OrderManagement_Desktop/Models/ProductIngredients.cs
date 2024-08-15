using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class ProductIngredients
    {
        public int ProductIngredientID { get; set; }
        public int ProductID { get; set; }
        public int IngredientID { get; set; }
        public decimal Quantity { get; set; }
    }
}
