using Abc.Data.Quantity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Infra.Quantity
{
    public class QuantityDbContext:DbContext
    {
        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }
        public DbSet<MeasureData> Measures { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
            InitializeTabels(builder);

        }

        private void InitializeTabels(ModelBuilder builder)
        {
            builder.Entity<MeasureData>().ToTable("Measure");
        }
    }
}
