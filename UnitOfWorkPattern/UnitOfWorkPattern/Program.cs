namespace UnitOfWorkPattern
{
    class Program
    {
        private readonly IUnitOfWork _unitOfWork;

        public Program(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Run()
        {
            using (_unitOfWork.BeginTransaction())
            {
                _unitOfWork.PersonRepository.Create("Marvin");
                _unitOfWork.AddressRepository.Create("Rua Louca, 045");
                _unitOfWork.PhoneRepository.Create("1234567890");

                _unitOfWork.CommitTransaction();
            }
        }
    }
}
