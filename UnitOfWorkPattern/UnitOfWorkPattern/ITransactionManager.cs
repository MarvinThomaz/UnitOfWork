using System;

namespace UnitOfWorkPattern
{
    interface ITransactionManager : IDisposable
    {
        IDisposable BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}