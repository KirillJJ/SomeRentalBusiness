namespace Domain.Services
{
    using System.Linq;
    using Entities;
    using Repositories;

    public class NameVerifier<T> : INameVerifier<T> where T : IUniqueNameEntity, IEntity
    {
        private readonly IRepository<T> _repository;


        public NameVerifier(IRepository<T> repository)
        {
            _repository = repository;
        }



        public bool IsFree(string name)
        {
            return _repository.All().All(x => x.GetUniqueName() != name);
        }
    }
}
