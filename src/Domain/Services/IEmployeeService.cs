using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IEmployeeService
    {
        void Add(string surname, string firstname, string patronymic);

    }
}
