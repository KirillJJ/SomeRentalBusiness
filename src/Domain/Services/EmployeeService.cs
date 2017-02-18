using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    using Entities;
    using Repositories;

    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        private readonly INameVerifier<Employee> _nameVerifier;

        public EmployeeService(IRepository<Employee> repository, INameVerifier<Employee> nameVerifier)
        {
            _repository = repository;
            _nameVerifier = nameVerifier;
        }

        public void Add(string surname, string firstname, string patronymic)
        {

            Employee employee = new Employee(surname, firstname, patronymic);

            if (!_nameVerifier.IsFree(employee.GetUniqueName()))
                throw new InvalidOperationException("Employee with same name already exists");

            _repository.Add(employee);
        }
    }
}
