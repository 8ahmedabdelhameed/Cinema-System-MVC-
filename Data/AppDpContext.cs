namespace ticket.Data
{
    public class  AppDpContext : DbContext
    {
        public AppDpContext(DbContextOptions<AppDpContext>options) : base(options)
        {
        
        }
        protected override void OnModelCreating(ModelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
