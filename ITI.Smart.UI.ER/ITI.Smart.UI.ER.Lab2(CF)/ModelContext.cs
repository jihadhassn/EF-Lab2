namespace ITI.Smart.UI.ER.Lab2_CF_
{
    using ITI.Smart.UI.ER.Lab2_CF_.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITI.Smart.UI.ER.Lab2_CF_.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set;}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().
               HasRequired(s => s.ContactInfo)
               .WithRequiredPrincipal(c => c.Student);

            modelBuilder.Entity<ContactInfo>().
                HasRequired(c => c.Student)
                .WithRequiredDependent(s => s.ContactInfo);
            base.OnModelCreating(modelBuilder);
        }

    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}