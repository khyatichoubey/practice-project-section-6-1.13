using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practice_project_6_1._13.Model;

namespace practice_project_6_1._13.Data
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext (DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public DbSet<practice_project_6_1._13.Model.School> School { get; set; } = default!;
    }
}
