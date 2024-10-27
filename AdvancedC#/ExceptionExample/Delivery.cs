using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_.ExceptionExample
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DeliveryStatus Status { get; set; }

        public override string ToString()
        {
            return $"{{\n   Id: {Id}\n   Name:{Name}\n   Address: {Address}\n   Status: {Status}\n}}";
        }

    }
}

public enum DeliveryStatus
{
    UNKNOWN,
    PROCESSING,
    SHIPPING,
    ONTRANSIT,
    DELIVERED
}