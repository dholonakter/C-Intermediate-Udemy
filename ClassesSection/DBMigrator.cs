using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSection
{
  public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            this._logger= logger;
        }
        public void Migrate()
        {
            _logger.Log("Migration started at " + DateTime.Now);
           
        }
    }

}
