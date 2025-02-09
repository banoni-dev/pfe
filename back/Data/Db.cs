using Microsoft.EntityFrameworkCore;
using back.Models;

namespace back.Data
{
    public class Db : DbContext
    {

        public Db(DbContextOptions<Db> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // models
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<TierModel> Tiers { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<SubscriptionModel> Subscriptions { get; set; }
        public DbSet<SessionModel> Sessions { get; set; }


    }
}

