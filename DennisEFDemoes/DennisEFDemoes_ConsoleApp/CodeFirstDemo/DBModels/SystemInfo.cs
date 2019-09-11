using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBModels
{
    public enum ServerType
    {
        WaspAPI = 0,
        WaspUI = 1,
        WBOneTool = 2,
    }
    public class SystemInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MaxLength(255)]
        public string ServerName { get; set; }

        [Required]
        public ServerType ServerType { get; set; }

        public string RunningAccount { get; set; }

        [MaxLength(255)]
        public string RunningCommand { get; set; }

        public string Description { get; set; }

        public DateTime LastResponseTime { get; set; }

        [Required]
        public long ResponseDelayThresholdInMinutes { get; set; }

        [Required]
        public bool Enable { get; set; }

        [Required]
        public DateTime CreatedDtm { get; set; }

        [Required]
        public DateTime ModifiedDtm { get; set; }

        [Required]
        public string ModifyAuthor { get; set; }

        public SystemInfo()
        {
            Enable = false;
            CreatedDtm = DateTime.UtcNow;
            ModifiedDtm = DateTime.UtcNow;
        }
    }
}
