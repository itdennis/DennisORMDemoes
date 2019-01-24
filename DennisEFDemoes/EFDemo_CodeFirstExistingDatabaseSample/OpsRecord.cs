namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OpsRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(450)]
        public string ExperimentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ModifiedDtm { get; set; }

        [Key]
        [Column(Order = 6)]
        public string OperationDetail { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool OperationResult { get; set; }
    }
}
