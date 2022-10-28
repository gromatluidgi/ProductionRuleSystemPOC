namespace BehavioralCriterias.Domain
{
    public class Issue
    {
        public Issue(string state)
        {
            State = state;
        }

        public string State { get; set; }
    }
}
