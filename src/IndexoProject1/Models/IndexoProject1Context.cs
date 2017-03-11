using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IndexoProject1.Models
{
    public class IndexoProject1Context : DbContext
    {
        public IndexoProject1Context (DbContextOptions<IndexoProject1Context> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
