using System;

namespace ManagementSystem.Database
{
    public abstract class Repository : IDisposable
    {
        protected Entities Context;

        public Repository()
        {
            Context = CreateDbContext();
        }

        private Entities CreateDbContext()
        {
            Context = new Entities();

            //Context.Configuration.AutoDetectChangesEnabled = false;
            Context.Configuration.ProxyCreationEnabled = false;

            return Context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing && (Context != null))
            {
                Context.Dispose();
            }
        }
    }
}
