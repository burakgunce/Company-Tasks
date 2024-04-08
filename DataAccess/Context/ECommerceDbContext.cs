using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ECommerceDbContext : IdentityDbContext<AppUser>
    {
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
