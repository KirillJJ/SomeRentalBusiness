

namespace App
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Repositories;
    using Domain.Services;
    using Domain.Entities.Deposits;

    public class App
    {
        private readonly IRepository<Bike> _bikeRepository;
        private readonly IBikeService _bikeService;
        private readonly IEmployeeService _employeeService;
        private readonly IRentPointService _rentPointService;
        private readonly IRepository<Client> _clientRepository;
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<RentPoint> _rentPointRepository;
        private readonly IRentService _rentService;



        public App(
            IRepository<Client> clientRepository,
            IRepository<Employee> employeeRepository,
            IRepository<Bike> bikeRepository,
            IBikeService bikeService,
            IEmployeeService employeeService,
            IRentPointService rentPointService,
            IRepository<RentPoint> rentPointRepository,
            IRentService rentService
        )
        {
            _clientRepository = clientRepository;
            _employeeRepository = employeeRepository;
            _bikeRepository = bikeRepository;
            _bikeService = bikeService;
            _clientRepository = clientRepository;
            _employeeService = employeeService;
            _rentPointRepository = rentPointRepository;
            _rentPointService = rentPointService;
            _rentService = rentService;
        }


        // Commands
        public void AddBike(string name, decimal hourCost)
        {
            _bikeService.AddBike(name, hourCost);
        }

        public IEnumerable<Bike> GetBikes()
        {
            return _bikeRepository.All();
        }

        public void AddEmployee(string surname, string firstname, string patronymic)
        {
            _employeeService.Add(surname, firstname, patronymic);
        }

        public void AddRentPoint(Employee employee,
            decimal money, string name)
        {
            _rentPointService.AddRentPoint(employee, money, name);
        }

        public void StartRent(Client client, Bike bike, Deposit deposit)
        {
            _rentService.Take(client, bike, deposit);
        }

        public void EndRent(Bike bike, RentPoint rentPoint)
        {
            _rentService.Return(bike, rentPoint);
        }


        // Queries

        public IEnumerable<RentPoint> GetAllRentPoints()
        {

        }

        public IEnumerable<Bike> GetFreeBikesAtRentPoint(RentPoint rentPoint)
        {

        }

        public IEnumerable<Employee> GetFreeEmployers()
        {

        }

        
    }
}
