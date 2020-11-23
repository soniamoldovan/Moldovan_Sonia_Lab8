using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Sonia_Lab8.Models;

namespace Moldovan_Sonia_Lab8.Data
{
    public class Moldovan_Sonia_Lab8Context : DbContext
    {
        public Moldovan_Sonia_Lab8Context (DbContextOptions<Moldovan_Sonia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Sonia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Moldovan_Sonia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Moldovan_Sonia_Lab8.Models.Category> Category { get; set; }
    }
}
