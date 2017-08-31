namespace UnitOfWorkPattern
{
    interface IUnitOfWork : ITransactionManager
    {
        IPersonRepository PersonRepository { get; }
        IAddressRepository AddressRepository { get; }
        IPhoneRepository PhoneRepository { get; }
    }
}
