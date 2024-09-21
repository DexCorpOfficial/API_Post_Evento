using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using API_Post_Eventos_Real.Models;


namespace API_Post_Eventos_Real.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Uploads> Uploads { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Evento> Evento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones si es necesario
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Upload)
                .WithMany()
                .HasForeignKey(p => p.id_de_uploads);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Post)
                .WithMany()
                .HasForeignKey(c => c.id_de_post);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Upload)
                .WithMany()
                .HasForeignKey(c => c.id_de_uploads);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Upload)
                .WithMany()
                .HasForeignKey(e => e.id_de_uploads);
        }
    }
}

