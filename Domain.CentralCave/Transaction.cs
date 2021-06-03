using System;

namespace Domain.CentralCave
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid IdUser { get; set; }

        public User User { get; set; }
    }
}
