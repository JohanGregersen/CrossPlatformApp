using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse
{
    public class DBController
    {
        private string _connectionString = "Server=tcp:drivelab.database.windows.net,1433;Initial Catalog=DriveLabDataWarehouse;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DBController()
        {
        }



    }
}
