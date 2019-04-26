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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Twitch Username")]
        public string TwitchUN { get; set; }

        [Display(Name = "League of Legends Username")]
        public string LeagueUN { get; set; }

        [Display(Name = "Discord Username")]
        public string DiscordUN { get; set; }

        [Display(Name = "Instagram Username")]
        public string InstagramUN { get; set; }

        [Display(Name = "Twitter Username")]
        public string TwitterUN { get; set; }

        [Display(Name = "Subscriber?")]
        public bool isSubscribed { get; set; }

        [Display(Name = "Which tier?")]
        public string Tier { get; set; }
    }
}
