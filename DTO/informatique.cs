namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
