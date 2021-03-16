namespace Inheritance_practice
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly CompositionLogger _logger;

            public DbMigrator(CompositionLogger logger)
            {
                this._logger = logger;
            }

            public void Migrate()
            {
                _logger.log("we are migrating...");
            }
        }
    }
}
