using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class DAPatientInformation
    {

        public static Boolean CreatePatientProfile(String id, String firstName, String lastName, String emailId, String password)
        {
            DataSet patientProfile = new DataSet();
            SqlConnection connection;
            String query = null;
            SqlCommand sqlCommand;
            SqlDataReader dataReader;

            DataTable dataTable = new DataTable();
            //ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            String cs = @"Data Source=localhost;Initial Catalog=master ;User ID=sa;Password=reallyStrongPwd123"; 
            connection = new SqlConnection(cs);
            query = "INSERT INTO employee (id, first_name, last_name, email, password) VALUES (" + id + ",'" + firstName + "'," + ",'" + lastName + "'," + ",'" + emailId + "'," + ",'" + password + "'";
            connection.Open();
            sqlCommand = new SqlCommand(query, connection);
            dataReader = sqlCommand.ExecuteReader();
            dataTable.Load(dataReader);

            patientProfile.Tables.Add(dataTable);
            dataReader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return true;
        }


        public static DataSet getPatientProfile(String email, String password){
            DataSet patientProfile = new DataSet();
            SqlConnection connection;
            String query = null;
            SqlCommand sqlCommand;
            SqlDataReader dataReader;

            DataTable dataTable = new DataTable();
            // As we unable to access connectionString from project, hardcoding connection strings
            //ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
            String cs = @"Data Source=localhost;Initial Catalog=master ;User ID=sa;Password=reallyStrongPwd123"; 
            connection = new SqlConnection(cs);
            query = "Select * from patient where email='"+email+"' and password='"+password+"'";
            connection.Open();
            sqlCommand = new SqlCommand(query, connection);
            dataReader = sqlCommand.ExecuteReader();
            dataTable.Load(dataReader);

            patientProfile.Tables.Add(dataTable);
            dataReader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return patientProfile;
        }
    }
}
