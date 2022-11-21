using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowProjectDesignPattern.EntityLayer.Concrete
{
    public class ProcessDetail
    {
        public int ProcessDetailID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
