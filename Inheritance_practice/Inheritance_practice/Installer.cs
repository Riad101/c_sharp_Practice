namespace Inheritance_practice
{
    partial class Program
    {
        public class Installer
        {
            private readonly CompositionLogger _logger;

            public Installer(CompositionLogger logger)
            {
                this._logger = logger;
            }

            public void Install()
            {
                _logger.log("we are installing...");
            }
        }
    }
}
