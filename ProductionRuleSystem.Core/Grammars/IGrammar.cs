using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core.Ast
{
    public interface IGrammar
    {
        string[] FactKeywords { get; }

        string[] RuleActionKeywords { get; }

        string[] RuleConditionKeywords { get; }
    }
}
