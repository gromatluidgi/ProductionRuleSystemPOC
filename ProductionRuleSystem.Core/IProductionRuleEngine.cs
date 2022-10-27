using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core
{
    public interface IProductionRuleEngine
    {
        IKnowledgeBase KnowledgeBase { get; }

        IWorkingMemory WorkingMemory { get; }

        void ForwardChaining();
    }
}
