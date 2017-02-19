using Domain.Entities;

namespace Domain.Services
{
    public interface IRentPointService
    {
        void AddRentPoint(Employee employee,
            decimal money, string name);

    }
}
