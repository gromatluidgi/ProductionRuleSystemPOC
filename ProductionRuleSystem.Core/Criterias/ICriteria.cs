namespace BehavioralCriterias.Core.Criterias
{
    internal interface ICriteria
    {
        bool Evaluate<T>(T context);
    }
}
