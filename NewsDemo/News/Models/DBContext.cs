using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace News.Models
{
    public class DBContext:DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<NewsModel> newsModels { set; get; }
    }
}