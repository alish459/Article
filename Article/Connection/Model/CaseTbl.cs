namespace Connection.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseTbl")]
    public partial class CaseTbl
    {
        [Key]
        public int CaseID { get; set; }

        public int AuthorID { get; set; }

        [Required]
        [StringLength(500)]
        public string Explain { get; set; }

        public virtual AuthorTbl AuthorTbl { get; set; }
    }
}
