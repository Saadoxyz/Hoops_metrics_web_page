namespace Hoops.Data
{
    public enum Position { PG, SG, SF, PF, C }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public Position Position { get; set; }
        public string Nationality { get; set; }

        public MatchPerformanceStats MatchStats { get; set; } = new();
        public FitnessStats FitnessStats { get; set; } = new();
        public InjuryHistory InjuryHistory { get; set; } = new();
    }
}
