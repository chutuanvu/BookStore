using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseHelper
    {
        public string connectString = @"Data Source=localhost,1433;Initial Catalog=da1;User ID=sa;Password=MsSQL2022@;";
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public DataTable dataTable;
        public SqlDataAdapter sqlDataAdapter;
        public void Ketnoi()
        {
            sqlConnection = new SqlConnection(connectString);
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
        }
        public void Ngatketnoi()
        {
            sqlConnection = new SqlConnection(connectString);
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Close();
        }

        public void Chaycodesql(string masql)
        {
            Ketnoi();
            sqlCommand.CommandText = masql;
            sqlCommand.ExecuteNonQuery();
            Ngatketnoi();
        }

        public DataTable GetData(string sql)
        {
            Ketnoi();
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Ngatketnoi();
            return dataTable;
        }
        public DataTable GetData(string sql, SqlParameter[] parameters)
        {
            Ketnoi();
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            foreach (var param in parameters)
            {
                sqlDataAdapter.SelectCommand.Parameters.Add(param);
            }
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Ngatketnoi();
            return dataTable;
        }

        public int LayGiaTri(string sql)
        {
            Ketnoi();
            sqlCommand.CommandText = sql;
            int giaTri = Convert.ToInt32(sqlCommand.ExecuteScalar());
            Ngatketnoi();
            return giaTri;
        }

        public int KiemTraMaTrung(string ma, string sql)
        {
            Ketnoi();
            int i;
            sqlCommand = new SqlCommand(sql, sqlConnection);
            i = (int)sqlCommand.ExecuteScalar();
            Ngatketnoi();
            return i;
        }

        public object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            Ketnoi();
            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                object result = command.ExecuteScalar();
                Ngatketnoi();
                return result;
            }
        }
    }
}
