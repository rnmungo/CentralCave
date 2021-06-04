using System;
using Domain.CentralCave.Enums;

namespace Domain.CentralCave
{
    public class Account
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CBU { get; set; }
        public Currency Currency { get; set; }
        public Guid IdUser { get; set; }

        public Account() { }

        public Account(long cbu, Currency currency)
        {
            this.CBU = cbu;
            this.Currency = currency;
        }
    }
}
