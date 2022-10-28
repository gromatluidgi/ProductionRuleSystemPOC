namespace BehavioralCriterias.Core.Criterias
{
    public interface ICriteriaDefinition
    {
        /// <summary>
        /// Criteria name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Criteria description.
        /// </summary>
        string Description { get; }
    }
}
