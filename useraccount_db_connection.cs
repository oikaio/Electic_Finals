using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace New_POS_Application
{
    class useraccount_db_connection
    {
        public String useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            //codes to establish connection from C# forms to the SQL Server database 
            useraccount_sql_connection = new SqlConnection();
            useraccount_connectionString = "Data Source = WYNE; Initial Catalog = POSDB;  user id = sa; password = anabelladoctor"; 
            useraccount_sql_connection = new SqlConnection(useraccount_connectionString);
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;
            useraccount_sql_connection.Open();
        }
        public void useraccount_cmd()//public function codes that support the mssql query 
        {
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }
        public void useraccount_sqladapterSelect()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command; 
            useraccount_sql_command.ExecuteNonQuery(); 
        } 
        public void useraccount_sqladapterInsert() 
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command; 
            useraccount_sql_command.ExecuteNonQuery(); 
        }
        public void useraccount_sqladapterDelete()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery(); 
        } 
 
        public void useraccount_sqladapterUpdate()
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery(); 
        } 
        public void useraccount_sqldatasetSELECT()
        { 
            useraccount_sql_dataset = new DataSet();useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl"); 
        }
        public void useraccount_sqldatasetSELECT_Account()
        {
            useraccount_sql_dataset = new DataSet();
        }
            
    }
}
