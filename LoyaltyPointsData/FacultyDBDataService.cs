using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace LoyaltyPointsData
{
    public class FacultyDBDataService
    {

        static string connectionString
        = "Data Source =localhost\\SQLEXPRESS; Initial Catalog = xPoints; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public FacultyDBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);

            //sqlConnection.Open();

            GetAllFaculty();
        }

        public List<Faculty> GetAllFaculty()
        {
            string selectStatement = "SELECT FacultyID, FacultyName FROM Faculty";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var faculties = new List<Faculty>();

            //deserialize
            while (reader.Read())
            {
                Faculty faculty = new Faculty();
                faculty.FacultyID = reader["FacultyID"].ToString();
                faculty.FacultyName = reader["FacultyName"].ToString();

                faculties.Add(faculty);
            }

            sqlConnection.Close();
            return faculties;

        }

        public bool CreateFaculty(Faculty faculty)
        {
            var insertStatement = "INSERT INTO Faculty VALUES (@FacultyID, @FacultyName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@FacultyID", faculty.FacultyID);
            insertCommand.Parameters.AddWithValue("@FacultyName", faculty.FacultyName);
            sqlConnection.Open();

            int rowsAffected = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return rowsAffected > 0;
        }

        public bool RemoveFaculty(Faculty faculty)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM Faculty WHERE FacultyID = @FacultyID";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@FacultyID", faculty.FacultyID);

            int rowsAffected = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return rowsAffected > 0;
        }

        public void UpdateFaculty(Faculty faculty)
        {
            sqlConnection.Open();

            var updateStatement = $"UPDATE Faculty SET FacultyID = @FacultyID, FacultyName= @FacultyNamae";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@FacultyID", faculty.FacultyID);
            updateCommand.Parameters.AddWithValue("@FacultyName", faculty.FacultyName);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

    }
}
