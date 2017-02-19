namespace Domain.Commands.CommandContext
{
    public class AddEmployeeCommandContext : ICommandContext
    {
        public string Surname { get; protected set; }

        public string FirstName{ get; protected set; }

        public string Patronymic{ get; protected set; }

        public AddEmployeeCommandContext(string surname, string firstName, string patronymic)
        {
            Surname = surname;
            FirstName = firstName;
            Patronymic = patronymic;
        }
    }
}