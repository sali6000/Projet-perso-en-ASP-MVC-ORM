namespace TutoLightReverse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("informatique")]
    public partial class informatique
    {
        [Key]
        [StringLength(50)]
        public string id_mot_cle { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }
    }
}
