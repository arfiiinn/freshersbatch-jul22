using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootballAssignment.Models
{
    public class FootballLeagueRepository : DbContext
    {
        public FootballLeagueRepository() : base("FootballLeagueContext")
        {
        }
        public DbSet<FootballLeagueforEF> FootballLeagueforEFs { get; set; }
    }
}