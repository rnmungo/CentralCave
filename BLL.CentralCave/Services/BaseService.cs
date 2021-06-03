using System;
using System.Transactions;
using log4net;

namespace BLL.CentralCave.Services
{
    public class BaseService
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void SurroundTransaction(Action action)
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try
                {
                    action();
                    trx.Complete();
                }
                catch (Exception ex)
                {
                    log.Error("Error en transacción de negocio", ex);
                    throw ex;
                }
            }
        }

        protected void SurroundTransaction(Action action, TransactionOptions options)
        {
            using (TransactionScope trx = new TransactionScope(TransactionScopeOption.Required, options))
            {
                try
                {
                    action();
                    trx.Complete();
                }
                catch (Exception ex)
                {
                    log.Error("Error en transacción de negocio", ex);
                    throw ex;
                }
            }
        }

        protected T SurroundTransaction<T>(Func<T> action)
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try
                {
                    var result = action();
                    trx.Complete();
                    return result;
                }
                catch (Exception ex)
                {
                    log.Error("Error en transacción de negocio", ex);
                    throw ex;
                }
            }
        }

        protected T SurroundTransaction<T>(Func<T> action, TransactionOptions options)
        {
            using (TransactionScope trx = new TransactionScope(TransactionScopeOption.Required, options))
            {
                try
                {
                    var result = action();
                    trx.Complete();
                    return result;
                }
                catch (Exception ex)
                {
                    log.Error("Error en transacción de negocio", ex);
                    throw ex;
                }
            }
        }
    }
}
