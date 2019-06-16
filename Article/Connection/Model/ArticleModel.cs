namespace Connection.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArticleModel : DbContext
    {
        public ArticleModel()
            : base("name=ArticleModel")
        {
        }

        public virtual DbSet<AntTbl> AntTbl { get; set; }
        public virtual DbSet<AuthorTbl> AuthorTbl { get; set; }
        public virtual DbSet<CaseTbl> CaseTbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AntTbl>()
                .Property(e => e.WordValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AuthorTbl>()
                .Property(e => e.TellNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AuthorTbl>()
                .Property(e => e.ArticleValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AuthorTbl>()
                .Property(e => e.NewsValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AuthorTbl>()
                .Property(e => e.TranslateValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AuthorTbl>()
                .HasMany(e => e.CaseTbl)
                .WithRequired(e => e.AuthorTbl)
                .WillCascadeOnDelete(false);
        }
    }
}
