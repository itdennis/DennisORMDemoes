namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilePublishStrategy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(255)]
        public string StrategyName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartitionCount { get; set; }

        [Key]
        [Column(Order = 2)]
        public string TargetModelFilePattern { get; set; }

        public string TargetRootPathSi { get; set; }

        public string TargetRootPathXLite { get; set; }

        [Key]
        [Column(Order = 3)]
        public string TargetRootPathProd { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Tag { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModelTarget { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ModifiedDtm { get; set; }
    }
}
