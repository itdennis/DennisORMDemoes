namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobMetricsView")]
    public partial class JobMetricsView
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
        public double AUC { get; set; }

        [Key]
        [Column(Order = 6)]
        public double PRAUC { get; set; }

        [Key]
        [Column(Order = 7)]
        public double LogLoss { get; set; }

        [Key]
        [Column(Order = 8)]
        public double RIG { get; set; }

        [Key]
        [Column(Order = 9)]
        public double PredictionError { get; set; }

        [Key]
        [Column(Order = 10)]
        public double AvgPclick { get; set; }

        public string ValidationDataName { get; set; }

        public string ValidationDataPath { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [StringLength(450)]
        public string ExperimentId { get; set; }

        public string JobDesc { get; set; }

        [Key]
        [Column(Order = 13)]
        public string Tag { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime TrainingEndTime { get; set; }

        [Key]
        [Column(Order = 15)]
        public string Config { get; set; }

        public string SubmitService { get; set; }

        [Key]
        [Column(Order = 16)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 18)]
        public DateTime ModifiedDtm { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LineCount { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Impressions { get; set; }

        [Key]
        [Column(Order = 21)]
        public double Ctr { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaxFeatureId { get; set; }
    }
}
