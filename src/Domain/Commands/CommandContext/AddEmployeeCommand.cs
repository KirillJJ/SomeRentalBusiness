using Domain.Services;

namespace Domain.Commands.CommandContext
{
    public class AddEmployeeCommand : ICommand<AddEmployeeCommandContext>
    {

        private readonly IEmployeeService _service;

        public AddEmployeeCommand(IEmployeeService service)
        {
            _service = service;
        }

        public void Execute(AddEmployeeCommandContext commandContext)
        {
            _service.Add(commandContext.FirstName, commandContext.Surname, commandContext.Patronymic);
        }
    }
}