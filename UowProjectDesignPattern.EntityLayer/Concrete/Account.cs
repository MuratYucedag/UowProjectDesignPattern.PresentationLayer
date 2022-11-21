using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowProjectDesignPattern.EntityLayer.Concrete
{
    public class Account
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
