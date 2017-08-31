namespace UnitOfWorkPattern
{
    interface IUnitOfWork : ITransactionManger
    {
        IPersonRepository PersonRepository { get; }
        IAddressRepository AddressRepository { get; }
        IPhoneRepository PhoneRepository { get; }
    }
}
