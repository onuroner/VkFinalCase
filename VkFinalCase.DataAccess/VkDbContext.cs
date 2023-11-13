using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base;
using VkFinalCase.Base.PaymentTypes;

namespace VkFinalCase.DataAccess
{
    public class VkDbContext:DbContext
    {
        public VkDbContext(DbContextOptions<VkDbContext> options): base(options)
        {
            
        }

        public DbSet<CreditCardPayment> CreditCardPayments { get; set; }
        public DbSet<EftTransaction> EftTransactions { get; set; }
        public DbSet<MoneyTransfer> MoneyTransfers { get; set; }
        public DbSet<OpenAccountPayment> OpenAccountPayments { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BillingInfo> BillingInfos { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserCredential> UserCredentials { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CreditCardPaymentConfiguration());
            modelBuilder.ApplyConfiguration(new EftTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new MoneyTransferConfiguration());
            modelBuilder.ApplyConfiguration(new OpenAccountPaymentConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new BillingInfoConfiguration());
            modelBuilder.ApplyConfiguration(new DealerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserCredentialConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
