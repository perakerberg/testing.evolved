using System.Collections.Generic;

namespace Testing.Evolved.SampleProject.Models
{
    public class Season
    {
        private readonly List<Round> _rounds = new List<Round>();
        private readonly List<Team> _teams = new List<Team>();
        public string SeasonName { get; }
        public IEnumerable<Round> Rounds => _rounds;
        public IEnumerable<Team> Teams => _teams;

        public Season(string seasonName)
        {
            this.SeasonName = seasonName;
        }

        public Round AddRound(Round round)
        {
            _rounds.Add(round);
            return round;
        }
        public Team AddTeam(Team team)
        {
            _teams.Add(team);
            return team;
        }
    }
}
