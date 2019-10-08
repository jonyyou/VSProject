using System.Data.Entity.ModelConfiguration.Conventions;

namespace EduMS.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EduContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“EduContext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“EduMS.Models.EduContext”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“EduContext”
        //连接字符串。
        public EduContext()
            : base("name=EduContext")
        {
            Database.SetInitializer<EduContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<OriginClass> OriginClass { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<NewsCategory> NewsCategory { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<PublishedCourse> PublishedCourse { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<CaltivatePlan> CaltivatePlan { get; set; }
        public DbSet<ControlCode> ControlCode { get; set; }



    }

    
}