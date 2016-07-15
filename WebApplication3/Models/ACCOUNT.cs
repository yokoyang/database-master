namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##APPUSER.ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(20)]
        public string USER_ID { get; set; }

        [StringLength(20)]
        public string PHONE { get; set; }

        [StringLength(20)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(20)]
        public string MAILBOX { get; set; }

        [Required]
        [StringLength(20)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(20)]
        public string USER_NAME { get; set; }
    }
}
