using Domain.Entities;

namespace Domain.Queries.Criteria
{
    public class GetFreeBikesAtRentPointCriteria : ICriterion
    {
        public RentPoint RentPoint { get; protected set; }

        public GetFreeBikesAtRentPointCriteria(RentPoint rentPoint)
        {
            RentPoint = rentPoint;
        }
    }
}