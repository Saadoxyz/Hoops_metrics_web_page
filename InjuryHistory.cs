namespace Hoops.Data
{
    public class InjuryHistory
    {
        public int GamesMissed { get; set; }
        public List<string> InjuryTypes { get; set; } = new();
    }
}
