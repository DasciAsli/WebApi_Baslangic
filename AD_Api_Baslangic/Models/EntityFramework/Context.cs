using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AD_Api_Baslangic.Models.EntityFramework
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}