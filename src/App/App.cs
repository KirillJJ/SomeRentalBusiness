using Domain.Commands;
using Domain.Commands.CommandContext;
using Domain.Queries;
using Domain.Queries.Criteria;

namespace App
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Repositories;
    using Domain.Services;
    using Domain.Entities.Deposits;

    public class App
    {
        //private readonly IRepository<Bike> _bikeRepository;
        /*private readonly IBikeService _bikeService;
        private readonly IEmployeeService _employeeService;
        private readonly IRentPointService _rentPointService;
        private readonly IRepository<Client> _clientRepository;
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<RentPoint> _rentPointRepository;
        private readonly IRentService _rentService;*/
        private readonly ICommandBuilder _commandBuilder;

        private readonly IQueryBuilder _queryBuilder;




        public App(
            ICommandBuilder commandBuilder,
            IQueryBuilder queryBuilder
            //IRepository<Client> clientRepository,
            //IRepository<Employee> employeeRepository,
            //IRepository<Bike> bikeRepository//,
            //IBikeService bikeService,
            //IEmployeeService employeeService,
            //IRentPointService rentPointService,
            //IRepository<RentPoint> rentPointRepository,
            //IRentService rentService
        )
        {
            _commandBuilder = commandBuilder;
            _queryBuilder = queryBuilder;
            /*_clientRepository = clientRepository;
            _employeeRepository = employeeRepository;*/
            //_bikeRepository = bikeRepository;
            /*_bikeService = bikeService;
            _clientRepository = clientRepository;
            _employeeService = employeeService;
            _rentPointRepository = rentPointRepository;
            _rentPointService = rentPointService;
            _rentService = rentService;*/
        }


        // Commands
        public void AddBike(string name, decimal hourCost)
        {
            _commandBuilder.Execute(new AddBikeCommandContext(name, hourCost));
            //_bikeService.AddBike(name, hourCost);
        }

        public void AddEmployee(string surname, string firstname, string patronymic)
        {
            _commandBuilder.Execute(new AddEmployeeCommandContext(surname, firstname, patronymic));
            //_employeeService.Add(surname, firstname, patronymic);
        }

        public void AddRentPoint(Employee employee, decimal money, string name)
        {
            _commandBuilder.Execute(new AddRentPointCommandContext(employee, money, name));
            //_rentPointService.AddRentPoint(employee, money, name);
        }

        public void StartRent(Client client, Bike bike, Deposit deposit)
        {
            _commandBuilder.Execute(new TakeBikeCommandContext(bike, client, deposit));
            //_rentService.Take(client, bike, deposit);
        }

        public void EndRent(Bike bike, RentPoint rentPoint)
        {
            _commandBuilder.Execute(new ReturnBikeCommandContext(bike,rentPoint));
           // _rentService.Return(bike, rentPoint);
        }


        // Queries

        public IEnumerable<RentPoint> GetAllRentPoints()
        {
            //IQueryFor<IEnumerable<RentPoint>> queryFor = _queryBuilder.For<IEnumerable<RentPoint>>();
            //queryFor.With
             return _queryBuilder.For<IEnumerable<RentPoint>>().With(new GetRentPointsCriterion());
        }

        public IEnumerable<Bike> GetFreeBikesAtRentPoint(RentPoint rentPoint)
        {
            return _queryBuilder.For<IEnumerable<Bike>>().With(new GetFreeBikesAtRentPointCriteria(rentPoint));
        }

        public IEnumerable<Employee> GetFreeEmployers()
        {

        }

        public IEnumerable<Bike> GetBikes()
        {
            return _queryBuilder.For<IEnumerable<Bike>>().With(new GetBikesCriteria());
            //return _bikeRepository.All();
        }
        
    }
}
