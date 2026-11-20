using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Data.SqlClient;

namespace LoyaltyPointsData
{
    public class FacultyDBMSService
    {
        static string connectionString
       = "Data Source =INDALEENQ\\SQLEXPRESS; Initial Catalog = PUPPoints; Integrated Security = True; TrustServerCertificate=True;";


        static SqlConnection sqlConnection;

        public FacultyDBMSService()
        {
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
        }

    }
}
