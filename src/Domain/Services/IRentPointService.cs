using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IRentPointService
    {
        void AddRentPoint(Employee employee,
            decimal money, string name);

    }
}
