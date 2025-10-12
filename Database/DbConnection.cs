using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string cannot be null or empty.");
            else
            {
                this.ConnectionString = connectionString;

            }
        }
        public virtual void Open()
        {

        }
        public virtual void Close()
        {
        }

    }
}
