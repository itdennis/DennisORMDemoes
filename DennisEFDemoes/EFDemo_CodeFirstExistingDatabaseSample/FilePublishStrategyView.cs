namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilePublishStrategyView")]
    public partial class FilePublishStrategyView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 3)]
        public string FilePublishStrategyName { get; set; }

        [Key]
        [Column(Order = 4)]
        public string ModelFilePattern { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr1 { get; set; }

        [Key]
        [Column(Order = 6)]
        public string CheckSumFilePattern { get; set; }

        [Key]
        [Column(Order = 7)]
        public string Tag { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModelTarget { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TargetEnv { get; set; }

        public string SourceExperimentId { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime TrainingEndTime { get; set; }

        public string PublishRecord { get; set; }

        [Key]
        [Column(Order = 11)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsManualPublish { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime ModifiedDtm { get; set; }

        [Key]
        [Column(Order = 15)]
        public string TargetModelFilePattern { get; set; }

        public string TargetRootPathSi { get; set; }

        public string TargetRootPathXLite { get; set; }

        [Key]
        [Column(Order = 16)]
        public string TargetRootPathProd { get; set; }
    }
}
