namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [StringLength(450)]
        public string ExperimentId { get; set; }

        public string JobDesc { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Tag { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime TrainingEndTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Config { get; set; }

        public string PublishRecord { get; set; }

        public string SubmitService { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobType { get; set; }

        [Key]
        [Column(Order = 7)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RetryTime { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime ModifiedDtm { get; set; }

        public string InterfaceConfig { get; set; }

        public string ValidationRecord { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationType { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LineCount { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Impressions { get; set; }

        [Key]
        [Column(Order = 14)]
        public double Ctr { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaxFeatureId { get; set; }
    }
}
