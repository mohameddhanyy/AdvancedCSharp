using AdvancedC_.ExceptionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_.Exceptions
{
    public class TransittingException : Exception
    {
        public string Location { get; set; }
        public TransittingException(Delivery delivery ,string locatoin, string message) : base(message)
        {
            Location = locatoin;
            delivery.Status = DeliveryStatus.UNKNOWN ;
        }
    }
}
