using System;

namespace Domain.CentralCave
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Account Wallet { get; set; }
        public Account SavingAccount { get; set; }
    }
}
