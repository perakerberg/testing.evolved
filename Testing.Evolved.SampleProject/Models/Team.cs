using System.Collections.Generic;

namespace Testing.Evolved.SampleProject.Models
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players => _players;

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }
    }
}
