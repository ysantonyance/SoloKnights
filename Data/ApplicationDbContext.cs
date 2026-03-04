using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoloKnights.Models.SupModels;
using SoloKnights.Models.MainModels;
using SoloKnights.Models.Enums;

namespace SoloKnights.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.StarterWeapon)
                .WithOne(sw => sw.Character)
                .HasForeignKey<StarterWeapon>(sw => sw.CharacterId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Passive)
                .WithMany()
                .HasForeignKey(c => c.PassiveId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CharacterSkill>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.Skills)
                .HasForeignKey(cs => cs.CharacterId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Skin>()
                .HasOne(s => s.Character)
                .WithMany(c => c.Skins)
                .HasForeignKey(s => s.CharacterId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Weapon>()
                .HasOne(w => w.Rarity)
                .WithMany(r => r.Weapons)
                .HasForeignKey(w => w.RarityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Enemy>()
                .HasOne(e => e.Level)
                .WithMany(l => l.Enemies)
                .HasForeignKey(e => e.LevelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Level>()
                .HasOne(l => l.Floor)
                .WithMany(f => f.Levels)
                .HasForeignKey(l => l.FloorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Biome>()
                .HasOne(b => b.Floor)
                .WithMany(f => f.Biomes)
                .HasForeignKey(b => b.FloorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Boss>()
                .HasOne(b => b.Biome)
                .WithMany(f => f.Bosses)
                .HasForeignKey(b => b.BiomeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Boss>()
                .HasOne(boss => boss.Biome)
                .WithMany(b => b.Bosses)
                .HasForeignKey(boss => boss.BiomeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GameObject>()
                .HasOne(o => o.Lobby)
                .WithMany(l => l.Objects)
                .HasForeignKey(o => o.LobbyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NPC>()
                .HasOne(n => n.Lobby)
                .WithMany(l => l.NPCs)
                .HasForeignKey(n => n.LobbyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<SoloKnights.Models.MainModels.Character> Character { get; set; } = default!;
    }
}
