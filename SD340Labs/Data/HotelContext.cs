#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD340Labs.Models;

namespace SD340Labs.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext (DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public DbSet<SD340Labs.Models.Client> Client { get; set; }
        public DbSet<SD340Labs.Models.Room> Room { get; set; }
        public DbSet<SD340Labs.Models.PhoneNumberCheckViewModel> PhoneNumberCheckViewModel { get; set; }
        public DbSet<SD340Labs.Models.Credit> Credit { get; set; }
    }
}
