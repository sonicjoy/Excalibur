using System;
using System.Data.Entity;
using Excalibur.Models.BabylonDb;

namespace Excalibur.Models
{
    public interface IRuleContext : IDisposable
    {
        DbSet<mapping_relation> mapping_relation { get; set; }
        DbSet<mapping_rule> mapping_rule { get; set; }
        DbSet<_operator> operators { get; set; }
        DbSet<rule> rules { get; set; }
        DbSet<source> sources { get; set; }
        DbSet<source_value> source_value { get; set; }
        DbSet<system> systems { get; set; }
        DbSet<target> targets { get; set; }
        DbSet<target_value> target_value { get; set; }
    }
}