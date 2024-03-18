using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Project.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Data Source=DESKTOP-AQ4CMVL\\DUCHUY;Initial Catalog=MMVM_LoginDB;Integrated Security=True;";
            //_connectionString = "Server=(local); Database= MMVM_LoginDB; Integrated Security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection( _connectionString );
        }
    }
}
