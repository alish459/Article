namespace Connection.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AntTbl")]
    public partial class AntTbl
    {
        [Key]
        public int AntID { get; set; }

        public bool ArticleGroup { get; set; }

        public bool NewsGroup { get; set; }

        public bool TranslateGroup { get; set; }

        [Required]
        [StringLength(500)]
        public string WordName { get; set; }

        [Required]
        [StringLength(1000)]
        public string SavePath { get; set; }

        public decimal WordValue { get; set; }

        public int AuthorID { get; set; }

        [Required]
        [StringLength(10)]
        public string ActDate { get; set; }

        public long WordCount { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }
    }
}
