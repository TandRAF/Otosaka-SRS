using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.Models;
using ZstdSharp.Unsafe;

namespace server.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options){}
        public DbSet<Card> Cards { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Desk> Desks { get; set; } 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
            builder.Entity<User>()
                .HasMany(u => u.Desks)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId);
            builder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne()
                .HasForeignKey<Profile>(p => p.UserId);
             builder.Entity<Desk>()
                .HasMany(d => d.Cards)
                .WithOne(c => c.Desk)
                .HasForeignKey(c => c.DeskId);
            builder.Entity<Desk>()
                .HasMany(d => d.SubDesks)
                .WithOne(d => d.ParentDesk)
                .HasForeignKey(d => d.ParentDeskId);
            builder.Entity<Note>()
                .HasMany(n => n.Cards)
                .WithOne(c => c.Note)
                .HasForeignKey(c => c.NoteId);
        } 
    };
}