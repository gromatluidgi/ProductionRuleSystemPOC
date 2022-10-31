using System.Collections.Generic;

namespace ProductionRuleSystem.Core.Facts
{
    /// <summary>
    /// Prototype for an abstract fact factory which aim's to provide a generic transformation
    /// mecanism for a aknowledged domain.
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
        Fact From<T>(T domainObject) where T: class;
    }
}
