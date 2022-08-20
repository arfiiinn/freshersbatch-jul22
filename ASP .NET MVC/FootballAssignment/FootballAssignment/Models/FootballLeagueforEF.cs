using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballAssignment.Models
{
    [Table("FootballLeagueforEF")]
    public class FootballLeagueforEF
    {
        [Key]
        [Required]
        public int MatchId { get; set; }
        [Required]
        public string TeamName1 { get; set; }
        [Required]
        public string TeamName2 { get; set; }
        [Required]
        public string Status { get; set; }

        public string WinningTeam { get; set; }
        [Required]
        public int Points { get; set; }
    }
}