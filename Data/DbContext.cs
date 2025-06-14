namespace eticket.Data
{
    public class DbContext
    {
        private DbContextOptions<AppDpContext> options;

        public DbContext(DbContextOptions<AppDpContext> options)
        {
            this.options = options;
        }

        internal void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}