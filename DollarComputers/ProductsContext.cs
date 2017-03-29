namespace DollarComputers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContextConnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
