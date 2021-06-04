using System;
using Domain.CentralCave.Enums;

namespace Domain.CentralCave
{
    public class Conversion
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Rate { get; set; }
        public Currency Origin { get; set; }
        public Currency Destination { get; set; }
    }
}
