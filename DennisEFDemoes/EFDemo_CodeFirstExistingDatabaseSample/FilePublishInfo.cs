namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilePublishInfo
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

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartitionCount { get; set; }

        [Key]
        [Column(Order = 4)]
        public string ModelFilePattern { get; set; }

        [Key]
        [Column(Order = 5)]
        public string CheckSumFilePattern { get; set; }

        [Key]
        [Column(Order = 6)]
        public string Tag { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModelTarget { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TargetEnv { get; set; }

        public string SourceExperimentId { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime TrainingEndTime { get; set; }

        public string PublishRecord { get; set; }

        [Key]
        [Column(Order = 10)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsManualPublish { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime ModifiedDtm { get; set; }

        [Key]
        [Column(Order = 14)]
        public string FilePublishStrategyName { get; set; }
    }
}
