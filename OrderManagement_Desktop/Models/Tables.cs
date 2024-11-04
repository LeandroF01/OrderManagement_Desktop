using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class Tables
    {
        public int TableID { get; set; }
        public int TableNumber { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public string Status { get; set; } = "Available"; // Default value
        public int Capacity { get; set; }
    }
}
