using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Queries.Criteria;

namespace Domain.Queries
{
    public class GetFreeBikesAtRentPointQuery : IQuery<GetFreeBikesAtRentPointCriteria, IEnumerable<Bike>>
    {
        public IEnumerable<Bike> Ask(GetFreeBikesAtRentPointCriteria criterion)
        {
            return (IEnumerable<Bike>) criterion.RentPoint.Bikes.Select(x => x.IsFree);// Почему я должен это кастить?
        }
    }
}