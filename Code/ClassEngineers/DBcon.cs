using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class DBcon
    {
        protected SqlCommand cmd;
        protected SqlConnection con;
        string connection = "Data Source=asus;Initial Catalog = Engineers; Integrated Security = True";
        public DBcon()
        {
            con = new SqlConnection(connection);
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
        }
    }
}
