using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Admin> admins { set; get; }

        public DbSet<Blogs> blogs { set; get; }

        public DbSet<Article> articles { set; get; }

        public DbSet<Revert> reverts { set; get; }

        #region 覆盖默认的约定----默认情况下EF将实体映射到数据库中dbo架构下的同名表上
        /// <summary>
        /// 覆盖默认的约定
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //移除EF映射默认给表名添加“s“或者“es”
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //解决办法
            modelBuilder.Entity<Admin>().ToTable("tb_Admin");
            modelBuilder.Entity<Blogs>().ToTable("tb_Blog");
            modelBuilder.Entity<Article>().ToTable("tb_Article");
            modelBuilder.Entity<Revert>().ToTable("tb_Revert");
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}