﻿namespace Domain.Queries
{
    using Criteria;

    public interface IQueryFor<out TResult>
    {
        TResult With<TCriterion>(TCriterion criterion)
            where TCriterion : ICriterion;

    }
}
