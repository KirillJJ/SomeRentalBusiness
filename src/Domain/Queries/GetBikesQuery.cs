using System.Collections.Generic;
using Domain.Entities;
using Domain.Queries.Criteria;
using Domain.Repositories;

namespace Domain.Queries
{
    public class GetBikesQuery : IQuery<GetBikesCriteria, IEnumerable<Bike>>
    {
        private readonly IRepository<Bike> _repository;

        public GetBikesQuery(IRepository<Bike> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Bike> Ask(GetBikesCriteria criterion)
        {
            return _repository.All();
        }
    }
}