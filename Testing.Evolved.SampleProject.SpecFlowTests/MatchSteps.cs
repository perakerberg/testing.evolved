using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Testing.Evolved.SampleProject.Models;
using Testing.Evolved.SpecFlow;

namespace Testing.Evolved.SampleProject.SpecFlowTests
{
    [Binding]
    public sealed class MatchSteps
    {
        [Given(@"a new season (.*) with these teams and players")]
        public void GivenANewSeasonWithTheseTeamsAndPlayers(string seasonName, Table table)
        {
            var season = new Season(seasonName);
            var league = new League();
            league.AddSeason(season);
            var teams = new List<Team>();
            foreach (var tableRow in table.Rows)
            {
                var teamName = tableRow[0];
                var team = season.Teams.FirstOrDefault(x => x.Name == teamName) ?? season.AddTeam(new Team(teamName));

                var playerName = tableRow[1];
                var player = team.Players.FirstOrDefault(x => x.Name == playerName) ?? team.AddPlayer(new Player(playerName));
            }
            season.SetInContext();
            league.SetInContext();
        }

        [Given(@"(.*) are the home team")]
        public void GivenTeamAreTheHomeTeam(string teamName)
        {
            Context.Get<Season>().Teams.First(x => x.Name == teamName).SetInContext("HomeTeam");
        }

        [Given(@"(.*) are the away team")]
        public void GivenTeamAreTheAwayTeam(string teamName)
        {
            Context.Get<Season>().Teams.First(x => x.Name == teamName).SetInContext("AwayTeam");
        }


    }

    
}
