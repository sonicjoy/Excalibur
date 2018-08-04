namespace Excalibur.Models.BabylonDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BabylonModel : DbContext
    {
        public BabylonModel()
            : base("name=BabylonModel")
        {
        }

        public virtual DbSet<mapping> mappings { get; set; }
        public virtual DbSet<rule> rules { get; set; }
        public virtual DbSet<rule_operator> rule_operator { get; set; }
        public virtual DbSet<source> sources { get; set; }
        public virtual DbSet<source_rule> source_rule { get; set; }
        public virtual DbSet<source_value> source_value { get; set; }
        public virtual DbSet<system> systems { get; set; }
        public virtual DbSet<target> targets { get; set; }
        public virtual DbSet<target_value> target_value { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mapping>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mapping>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<rule>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<rule>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<rule>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<rule>()
                .HasMany(e => e.source_rule)
                .WithRequired(e => e.rule)
                .HasForeignKey(e => e.rule_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rule_operator>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<rule_operator>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<rule_operator>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<rule_operator>()
                .HasMany(e => e.rules)
                .WithRequired(e => e.rule_operator)
                .HasForeignKey(e => e.operator_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<source>()
                .Property(e => e.entity_name)
                .IsUnicode(false);

            modelBuilder.Entity<source>()
                .Property(e => e.field_name)
                .IsUnicode(false);

            modelBuilder.Entity<source>()
                .Property(e => e.data_type)
                .IsUnicode(false);

            modelBuilder.Entity<source>()
                .HasMany(e => e.mappings)
                .WithRequired(e => e.source)
                .HasForeignKey(e => e.source_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<source>()
                .HasMany(e => e.source_rule)
                .WithRequired(e => e.source)
                .HasForeignKey(e => e.source_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<source>()
                .HasMany(e => e.source_value)
                .WithRequired(e => e.source)
                .HasForeignKey(e => e.source_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<source_rule>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<source_rule>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<source_value>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<source_value>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<source_value>()
                .Property(e => e.reference)
                .IsUnicode(false);

            modelBuilder.Entity<system>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<system>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<system>()
                .HasMany(e => e.sources)
                .WithRequired(e => e.system)
                .HasForeignKey(e => e.system_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<target>()
                .Property(e => e.entity_name)
                .IsUnicode(false);

            modelBuilder.Entity<target>()
                .Property(e => e.field_name)
                .IsUnicode(false);

            modelBuilder.Entity<target>()
                .Property(e => e.data_type)
                .IsUnicode(false);

            modelBuilder.Entity<target>()
                .HasMany(e => e.mappings)
                .WithRequired(e => e.target)
                .HasForeignKey(e => e.target_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<target>()
                .HasMany(e => e.target_value)
                .WithRequired(e => e.target)
                .HasForeignKey(e => e.target_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<target_value>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<target_value>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<target_value>()
                .Property(e => e.reference)
                .IsUnicode(false);
        }
    }
}
