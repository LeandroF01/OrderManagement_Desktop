using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class PaymentMethods
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public string PaymentType { get; set; } 
        public decimal Amount { get; set; }
    }
}
