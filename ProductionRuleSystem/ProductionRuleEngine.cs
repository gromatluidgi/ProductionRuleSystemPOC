using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Engines;
using System.Linq;

namespace BehavioralCriterias
{
    public class ProductionRuleEngine : IProductionRuleEngine
    {
        private readonly IKnowledgeBase _knowledgeBase;
        private readonly IWorkingMemory _workingMemory;

        public ProductionRuleEngine(IKnowledgeBase knowledgeBase, IWorkingMemory workingMemory)
        {
            _knowledgeBase = knowledgeBase;
            _workingMemory = workingMemory;
        }

        public IKnowledgeBase KnowledgeBase => _knowledgeBase;

        public IWorkingMemory WorkingMemory => _workingMemory;

        public void ForwardChaining() {
            // this is rudimentary... consider handling conflicts
            var rules = _knowledgeBase.Rules.Where(rule => rule.Evaluate(_workingMemory));
            foreach (var rule in rules)
            {
                rule.Execute(_workingMemory);
            }

        }
    }
}
