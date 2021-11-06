using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud.Models;

namespace Crud.Datos
{
    public class conexionBD:DbContext
    {

        public conexionBD(DbContextOptions<conexionBD> options):base(options)
        {

        }
        public DbSet<cita> citas { get; set; }

    }
}
