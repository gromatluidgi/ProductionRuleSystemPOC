namespace ProductionRuleSystem.Core.Engines
{
    public interface IProductionRuleEngine
    {
        IKnowledgeBase KnowledgeBase { get; }

        IWorkingMemory WorkingMemory { get; }


        void ForwardChaining();

    }
}
