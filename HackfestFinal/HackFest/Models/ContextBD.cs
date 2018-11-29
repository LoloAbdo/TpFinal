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
        public DbSet<Article> Articles { get; set; }
        public DbSet<Organisateur> Organisateurs { get; set; }
        public DbSet<MembreArticle> MembreArticles { get; set; }
        public DbSet<Membre> Membres { get; set; }
        public DbSet<Specialite> Specialites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembreArticle>(entity =>
            {
                entity.HasKey(c => new { c.ID_Article, c.ID_Membre });

                // article = propriete avec l'objet (Dans MembreArticle)
                entity.HasOne(d => d.Article)
                      .WithMany(p => p.MembreArticles)
                      .HasForeignKey(d => d.ID_Article)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(m => m.Membre)
                      .WithMany(p => p.MembreArticles)
                      .HasForeignKey(m => m.ID_Membre)
                      .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
