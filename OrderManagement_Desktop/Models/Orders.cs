using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class Orders
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; } 
        public decimal Total { get; set; }
        // Navigation property for User
        [ForeignKey("UserID")]
        public virtual Users Users { get; set; }

    }
}
