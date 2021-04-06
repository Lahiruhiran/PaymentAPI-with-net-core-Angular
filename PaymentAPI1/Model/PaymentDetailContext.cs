using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI1.Model
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) :base(options)
        {

        }
        public DbSet<PaymentDetail> MyPayment { get; set; }
    }
}
