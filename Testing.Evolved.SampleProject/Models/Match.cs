﻿using System.Collections.Generic;

namespace Testing.Evolved.SampleProject.Models
{
    public class Match
    {
        public Match(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public Team HomeTeam { get; }
        public Team AwayTeam { get; }

        public IEnumerable<Goal> HomeGoals { get; set; }
        public IEnumerable<Goal> AwayGoals { get; set; }
    }
}
