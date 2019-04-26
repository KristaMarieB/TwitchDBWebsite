using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TwitchDBWebsite.Models
{
    public class TwitchDBContext : DbContext
    {
        public TwitchDBContext (DbContextOptions<TwitchDBContext> options)
            : base(options)
        {
        }

        public DbSet<TwitchDBWebsite.Models.Person> Person { get; set; }
    }
}
