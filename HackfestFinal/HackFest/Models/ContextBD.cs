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

        public DbSet<Article> Articles { get; set; }
        public DbSet<Membre> Membres { get; set; }
        public DbSet<MembreArticle> MembreArticles { get; set; }
        public DbSet<Organisateur> Organisateurs { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<VersionArticle> VersionArticles { get; set; }


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

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(k => new { k.ID_Article, k.ID_Membre });

                entity.HasOne(a => a.Article)
                      .WithMany(s => s.Session)
                      .HasForeignKey(a => a.ID_Article)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(m => m.Membre)
                      .WithMany(s => s.Session)
                      .HasForeignKey(m => m.ID_Membre)
                      .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
