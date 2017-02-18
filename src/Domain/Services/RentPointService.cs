using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    using Repositories;
    using Entities;

    public class RentPointService : IRentPointService
    {
        private readonly IRepository<RentPoint> _repository;
        private readonly INameVerifier<RentPoint> _nameVerifier;

        public RentPointService(IRepository<RentPoint> repository, INameVerifier<RentPoint> nameVerifier)
        {
            _repository = repository;
            _nameVerifier = nameVerifier;
        }

        public void AddRentPoint(Employee employee, decimal money, string name)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (money < 0)
                throw new ArgumentOutOfRangeException(nameof(money));

            if (_nameVerifier.IsFree(name))
                throw new InvalidOperationException("RentPoint with same name already exists");

            _repository.Add(new RentPoint(employee, money, name));
        }
    }
}
