using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Models
{
    internal class Users
    {    
            public int UserID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string UserType { get; set; }      
    }
}
