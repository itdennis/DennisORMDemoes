namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MetricsInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JobId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Slice { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Impression { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Click { get; set; }

        [Key]
        [Column(Order = 5)]
        public double CTR { get; set; }

        [Key]
        [Column(Order = 6)]
        public double AUC { get; set; }

        [Key]
        [Column(Order = 7)]
        public double PRAUC { get; set; }

        [Key]
        [Column(Order = 8)]
        public double LogLoss { get; set; }

        [Key]
        [Column(Order = 9)]
        public double RIG { get; set; }

        [Key]
        [Column(Order = 10)]
        public double PredictionError { get; set; }

        [Key]
        [Column(Order = 11)]
        public double AvgPclick { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime CreatedDtm { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime ModifiedDtm { get; set; }

        public string ValidationDataName { get; set; }

        public string ValidationDataPath { get; set; }
    }
}
