namespace BehavioralCriterias.Domain
{
    public class Issue
    {
        public Issue(int id, string state)
        {
            Id = id;
            State = state;
        }

        public int Id { get; }

        public string State { get; set; }
    }
}
