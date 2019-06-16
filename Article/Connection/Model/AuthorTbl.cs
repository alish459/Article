namespace Connection.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthorTbl")]
    public partial class AuthorTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuthorTbl()
        {
            CaseTbl = new HashSet<CaseTbl>();
        }

        [Key]
        public int AuthorID { get; set; }

        [Required]
        [StringLength(500)]
        public string AuthorName { get; set; }

        public bool ArticleGroup { get; set; }

        public bool NewsGroup { get; set; }

        public bool TranslateGroup { get; set; }

        [Required]
        [StringLength(500)]
        public string TellNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string BankName { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        public decimal ArticleValue { get; set; }

        public decimal NewsValue { get; set; }

        public decimal TranslateValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaseTbl> CaseTbl { get; set; }
    }
}
