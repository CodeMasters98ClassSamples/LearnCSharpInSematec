using BaseBackend.Businesses.Interfaces;
using BaseBackend.Entities;
using BaseBackend.Enums;
using System.Configuration;
using System.Data.SqlClient;

namespace BaseBackend.Businesses;

public class StudentBusiness : IBaseBusiness<Student>
{
    string connectionString = ConfigurationManager.ConnectionStrings["LearnCSharpDb"].ToString();

    public StudentBusiness()
    {
        
    }

    public List<Student> GetAll()
    {

        //USE EF -> Use an ORM
        List<Student> students = new List<Student>();

        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "[User]";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to select data from the table
                string query = $"SELECT Id,FirstName, LastName, PhoneNumber,NationalCode,Gender FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        NationalCode = reader["NationalCode"].ToString(),
                        Gender = (Gender)int.Parse(reader["Gender"].ToString() ?? "0"),
                    };
                    students.Add(student);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();

            }
            return students;
        }
    }

    public bool Add(Student student)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string tableName = "[User]";
                string query = $"INSERT INTO {tableName} (FirstName, LastName, PhoneNumber) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public bool Update(Student student)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string tableName = "[User]";
                string query = $"UPDATE {tableName} " +
                    $"SET FirstName = @FirstName," +
                    $"LastName = @LastName, " +
                    $"PhoneNumber = @PhoneNumber, " +
                    $"IsDeleted = @IsDeleted, " +
                    $"DeletedAt = @DeletedAt, " +
                    $"NationalCode = @NationalCode " +
                    $"WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                command.Parameters.AddWithValue("@NationalCode", student.NationalCode);
                command.Parameters.AddWithValue("@DeletedAt", student.DeletedAt);
                command.Parameters.AddWithValue("@IsDeleted", student.IsDeleted);
                command.Parameters.AddWithValue("@Id", student.Id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public bool Delete(int Id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string tableName = "[User]";
                string query = $"DELETE {tableName} WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

}
