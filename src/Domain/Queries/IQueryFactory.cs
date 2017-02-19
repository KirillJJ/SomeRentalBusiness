namespace Domain.Queries
{
    using Criteria;

    public interface IQueryFactory
    {
        IQuery<TCriterion, TResult> Create<TCriterion, TResult>()
            where TCriterion : ICriterion;
    }
}
