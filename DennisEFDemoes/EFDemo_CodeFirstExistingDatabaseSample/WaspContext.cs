namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WaspContext : DbContext
    {
        public WaspContext()
            : base("name=WaspContext")
        {
        }

        public virtual DbSet<ConfigInfo> ConfigInfoes { get; set; }
        public virtual DbSet<FilePublishInfo> FilePublishInfoes { get; set; }
        public virtual DbSet<FilePublishStrategy> FilePublishStrategies { get; set; }
        public virtual DbSet<JobInfo> JobInfoes { get; set; }
        public virtual DbSet<MetricsInfo> MetricsInfoes { get; set; }
        public virtual DbSet<MonitorInfo> MonitorInfoes { get; set; }
        public virtual DbSet<OpsRecord> OpsRecords { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<FilePublishStrategyView> FilePublishStrategyViews { get; set; }
        public virtual DbSet<JobMetricsView> JobMetricsViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
