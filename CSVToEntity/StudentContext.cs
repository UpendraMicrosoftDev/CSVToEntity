using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CSVToEntity
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> studentEntity { get; set; }
    }
}
