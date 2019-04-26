using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchDBWebsite.Models
{
    public class Person
    {
        [Required]
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string TwitchUN { get; set; }

        public string LeagueUN { get; set; }

        public string DiscordUN { get; set; }

        public string InstagramUN { get; set; }

        public string TwitterUN { get; set; }
        
        public bool isSubscribed { get; set; }

        public string Tier { get; set; }
    }
}
