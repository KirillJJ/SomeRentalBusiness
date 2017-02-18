namespace Domain.Services
{
    using Entities;

    public interface INameVerifier<T> where T : IUniqueNameEntity
    {
        bool IsFree(string name);
    }
}
