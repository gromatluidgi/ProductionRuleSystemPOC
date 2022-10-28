namespace BehavioralCriterias.Core.Criterias
{
    internal class CriteriaProperty
    {
        /// <summary>
        /// Creates a new criteria property.
        /// </summary>
        /// <param name="name">Criteria property name.</param>
        /// <param name="value">Criteria property value.</param>
        public CriteriaProperty(string name, object value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Criteria property name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Criteria property value.
        /// </summary>
        public object Value { get; }
    }
}
