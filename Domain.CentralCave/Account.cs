using System;
using Domain.CentralCave.Enums;

namespace Domain.CentralCave
{
    public class Account
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CBU { get; set; }
        public long CUIT { get; set; }
        public Currency Currency { get; set; }
        public Guid IdUser { get; set; }

        public Account() { }

        public Account(long cbu, long cuit, Currency currency)
        {
            this.CBU = cbu;
            this.CUIT = cuit;
            this.Currency = currency;
        }
    }
}
