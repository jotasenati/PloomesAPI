using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PloomesAPI.Models
{
    public class BancoContexto : DbContext
    {
        public BancoContexto (DbContextOptions<BancoContexto> options)
            : base(options)
        {
        }

        public DbSet<PloomesAPI.Models.Produto> Produto { get; set; }
    }
}
