using System.Collections.Generic;

namespace Testing.Evolved.SampleProject.Models
{
    public class League
    {
        private readonly List<Season> _seasons;
        public IEnumerable<Season> Seasons => _seasons;

        public League()
        {
            _seasons = new List<Season>();
        }
        public void AddSeason(Season season)
        {
            _seasons.Add(season);
        }
    }

}
