using DataModel.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models.DataProviders.SqlServer
{
    public class InfoContext : DbContext
    {
        DbSet<Info> Infos { get; set; }
    }
}
