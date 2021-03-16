using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var dbMigrator = new DbMigrator(new CompositionLogger());

            var logger = new CompositionLogger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();








            //class presentationObject
            //var text = new Text();
            //text.Width = 100;
            //text.copy();
        }
    }
}
