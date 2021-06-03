using System;
using System.Linq;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Factories;
using Domain.CentralCave;
using BLL.CentralCave.Contracts;
using BLL.CentralCave.BusinessExceptions;
using System.Collections.Generic;

namespace BLL.CentralCave.Services
{
    public sealed class AccountService : BaseService, IAccountService
    {
        IInserter<Movement> movementRepository = Factory.Current.GetMovementRepository();
        IInserter<Transaction> transactionRepository = Factory.Current.GetTransactionRepository();
        IGetterRelationship<Account, Movement> accountRepository = Factory.Current.GetAccountRepository();

        #region Singleton
        private readonly static AccountService _instance = new AccountService();

        public static AccountService Current
        {
            get
            {
                return _instance;
            }
        }

        private AccountService() { }
        #endregion

        public void ConvertTo(Account origin, Account destination, decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Deposit(Account account, decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidTransactionException("the amount must be greater than zero");
            }

            System.Transactions.TransactionOptions options = new System.Transactions.TransactionOptions()
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted
            };

            SurroundTransaction(() =>
            {
                Transaction transaction = new Transaction();
                transactionRepository.Insert(transaction);
                Movement movement = new Movement()
                {
                    Reason = Domain.CentralCave.Enums.Reason.DEPOSIT,
                    IdAccount = account.Id,
                    IdTransaction = transaction.Id,
                    Amount = amount
                };
                movementRepository.Insert(movement);
            }, options);
        }

        public void Transfer(Account origin, Account destination, decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidTransactionException("the amount must be greater than zero");
            }

            System.Transactions.TransactionOptions options = new System.Transactions.TransactionOptions()
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted
            };

            SurroundTransaction(() =>
            {
                List<Movement> movements = accountRepository.GetRelated(origin);
                if (movements.Sum(m => m.Amount) < amount)
                {
                    throw new InvalidTransactionException("the balance is insufficient");
                }

                Transaction transaction = new Transaction();
                transactionRepository.Insert(transaction);
                Movement output = new Movement()
                {
                    Reason = Domain.CentralCave.Enums.Reason.TRANSFER,
                    IdAccount = origin.Id,
                    IdTransaction = transaction.Id,
                    Amount = -amount
                };
                movementRepository.Insert(output);

                Movement input = new Movement()
                {
                    Reason = Domain.CentralCave.Enums.Reason.TRANSFER,
                    IdAccount = destination.Id,
                    IdTransaction = transaction.Id,
                    Amount = amount
                };
                movementRepository.Insert(input);
            }, options);
        }

        public Account GetOne(long cbu) => accountRepository.GetOne(cbu);
    }
}
