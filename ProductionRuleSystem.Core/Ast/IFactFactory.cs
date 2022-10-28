namespace ProductionRuleSystem.Core.Ast
{
    /// <summary>
    /// Prototype for an abstract fact factory.
    /// </summary>
    public interface IFactFactory
    {
        /// <summary>
        /// Transform an object with a generic type into the appropriate
        /// facts.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="domainObject"></param>
        /// <returns></returns>
        Fact From<T>(T domainObject);
    }
}
