using ProductionRuleSystem.Core;
using System;
using System.Linq;

namespace BehavioralCriterias
{
    public class ProductionRuleEngine : IProductionRuleEngine, IDisposable
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ForwardChaining() {
            // this is rudimentary... consider handling conflicts
            var rules = _knowledgeBase.GetRules().Where(rule => rule.Evaluate(_workingMemory));
            foreach (var rule in rules)
            {
                rule.Execute(_workingMemory);
            }

        }
    }
}
