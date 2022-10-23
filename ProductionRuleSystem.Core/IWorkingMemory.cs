using BehavioralCriterias.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core
{
    public interface IWorkingMemory
    {
        bool IsFact(Expression expression);
    }
}
