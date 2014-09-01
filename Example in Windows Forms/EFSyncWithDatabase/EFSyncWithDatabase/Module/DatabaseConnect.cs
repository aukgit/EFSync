using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSyncWithDatabase.Module
{
    class SQLServerDatabaseConnect
    {
        public SqlDataAdapter Adapter { get; set; }
        public string DatabaseLocation { get; set; }

        public string DatabaseName { get; set; }
        public string[] ListOfTables { get; set; }
        public string[] ListOfRelations { get; set; }

        /// <summary>
        /// Will be populated from GetConnection method.
        /// </summary>
        private SqlConnection sqlConnection;

        /// <summary>
        /// Connection Open
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <returns></returns>
        public SqlConnection GetConnection(string ConnectionString)
        {
           
        }

        public bool InstanticateAdapter(SqlConnection connect)
        {

        }

        public void ChangeSQL(string sql)
        {
            Adapter.SelectCommand.CommandText = sql;

        }

        public DataTable ExecuteSQL(string sql)
        {
            DataTable dt= new DataTable();

            ChangeSQL(sql);
            Adapter.Fill(dt);
            return dt;

        }

        public void ExecuteNonReturnSQL(string sql)
        {
            ChangeSQL(sql);
            Adapter.SelectCommand.ExecuteNonQuery();

        }



        public bool DetachDatabase(SqlConnection connect)
        {

        }

    }
}
