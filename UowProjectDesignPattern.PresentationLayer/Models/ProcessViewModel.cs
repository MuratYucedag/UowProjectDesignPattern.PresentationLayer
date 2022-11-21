using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UowProjectDesignPattern.PresentationLayer.Models
{
    public class ProcessViewModel
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public int Amount { get; set; }
    }
}
