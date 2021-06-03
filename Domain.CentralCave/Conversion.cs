using Domain.CentralCave.Enums;

namespace Domain.CentralCave
{
    public class Conversion
    {
        public decimal Rate { get; set; }
        public Currency Origin { get; set; }
        public Currency Destination { get; set; }
    }
}
