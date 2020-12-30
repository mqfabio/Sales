using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWMvc.Models;

namespace SalesWMvc.Data
{
    public class SalesWMvcContext : DbContext
    {
        public SalesWMvcContext (DbContextOptions<SalesWMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWMvc.Models.Department> Department { get; set; }
    }
}
