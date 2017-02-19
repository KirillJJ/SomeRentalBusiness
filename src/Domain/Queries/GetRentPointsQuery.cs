using Domain.Queries.Criteria;
using System.Collections.Generic;
using System;
using Domain.Entities;
using Domain.Repositories;

namespace Domain.Queries
{
    public class GetRentPointsQuery : IQuery<GetRentPointsCriterion, IEnumerable<RentPoint>>
    {
        private readonly IRepository<RentPoint> _repository;
        public IEnumerable<RentPoint> Ask(GetRentPointsCriterion criterion)
        {
            return _repository.All();
        }
    }
}