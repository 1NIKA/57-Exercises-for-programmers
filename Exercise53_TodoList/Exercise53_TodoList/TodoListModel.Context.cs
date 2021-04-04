namespace Exercise53_TodoList
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TodoListEntities : DbContext
    {
        public TodoListEntities()
            : base("name=TodoListEntities") { }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}
