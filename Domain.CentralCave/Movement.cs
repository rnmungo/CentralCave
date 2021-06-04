using System;
using Domain.CentralCave.Enums;

namespace Domain.CentralCave
{
    public class Movement
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Reason Reason { get; set; }
        public Guid IdAccount { get; set; }
        public decimal Amount { get; set; }
        public long IdTransaction { get; set; }

        public Account Account { get; set; }
    }
}
