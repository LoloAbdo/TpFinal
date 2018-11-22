using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { }

        public DbSet<Participant> Participants { get; set; }
    }
}
