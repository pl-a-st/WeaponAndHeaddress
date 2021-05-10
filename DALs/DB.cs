using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALs
{
    public class DB
    {
        public string ConnectionString
        {
            get;
        } = "Data Source = NB-TO-4-1\\DREAM; Initial Catalog = TimeToBurnFear; Integrated Security = True";
        private SqlConnection sqlConnection;
        public void Connect()
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        }

        public void Disconnect()
        {
            sqlConnection.Close();
        }

        public void InsertData(TableType tableType, string weaponName, int damage)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into "+  TableName.GetTableNameByTableType(tableType)+
                " (name, damage) values ('" + weaponName + "'," + damage + ")", sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
        public void RemooveData(TableType tableType, string weaponName, int damage, int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update " + TableName.GetTableNameByTableType(tableType) + " set name ='" + weaponName + 
                "', damage=" + damage +" where id =" + id , sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
