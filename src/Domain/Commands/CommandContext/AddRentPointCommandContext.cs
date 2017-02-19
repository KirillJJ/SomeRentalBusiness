using Domain.Entities;

namespace Domain.Commands.CommandContext
{
    public class AddRentPointCommandContext : ICommandContext
    {
        public Employee Employee { get; protected set; }
        public decimal Money { get; protected set; }
        public string Name { get; protected set; }

        public AddRentPointCommandContext(Employee employee, decimal money, string name)
        {
            Employee = employee;
            Money = money;
            Name = name;
        }
    }
}