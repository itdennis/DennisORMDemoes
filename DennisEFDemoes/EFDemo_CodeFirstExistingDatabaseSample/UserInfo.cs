namespace EFDemo_CodeFirstExistingDatabaseSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [StringLength(255)]
        public string UserAlias { get; set; }

        [Key]
        [Column(Order = 2)]
        public string UserDomain { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserRole { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreatedDtm { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ModifiedDtm { get; set; }
    }
}
