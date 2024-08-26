using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace OrderManagement_Desktop.Models
{
    internal class Products
    {
        [JsonIgnore]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        [JsonIgnore]
        public decimal Stock { get; set; }
        [JsonIgnore]
        public string ImageURL { get; set; }

    }
}
