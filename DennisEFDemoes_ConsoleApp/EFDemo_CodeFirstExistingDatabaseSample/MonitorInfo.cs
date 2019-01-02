namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MonitorInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        public string Config { get; set; }

        [Key]
        [Column(Order = 2)]
        public string SubmitService { get; set; }

        public string ServiceHost { get; set; }

        [Key]
        [Column(Order = 3)]
        public string MonitorType { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 5)]
        public string ReportMailBody { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime ReportDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreatedDtm { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ModifiedDtm { get; set; }
    }
}
