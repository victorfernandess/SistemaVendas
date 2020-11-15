using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendedores.Models;

namespace SistemaVendedores.Data
{
    public class SistemaVendedoresContext : DbContext
    {
        public SistemaVendedoresContext (DbContextOptions<SistemaVendedoresContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaVendedores.Models.Department> Department { get; set; }
    }
}
