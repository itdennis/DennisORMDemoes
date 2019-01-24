namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfigInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(450)]
        public string ConfigName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [Key]
        [Column(Order = 3)]
        public string ConfigPayload { get; set; }

        public string Desc { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Owner { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubmitIntervalHours { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateDtm { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ModifiedDtm { get; set; }

        public string InterfaceConfigPayload { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobType { get; set; }
    }
}
