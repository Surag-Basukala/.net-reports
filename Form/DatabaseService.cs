using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Win32;
using Npgsql;
using Winforms.Models;

namespace Winforms
{
    public class DatabaseService
    {
        private readonly string _connection;
        public DatabaseService() {
            this._connection = "Server = localhost;Port = 5432; User Id=postgres;Password=garus;Database=postgres";
        }

        public string load_register(RegisterForm register)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connection))
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(
                        @"INSERT INTO register (name,age,gender,province,district)
                        VALUES (@name, @age, @gender, @province, @district)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", register.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@age", register.Age ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@gender", register.Gender ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@province", register.Province ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@district", register.District ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Registration Successful.";
            }
            catch (NpgsqlException ex)
            {
                return $"Database error : {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An error occured: {ex.Message}";
            }

        }
    public IReadOnlyList<RegisterForm> getAllUser()
        {
            List<RegisterForm> users = new List<RegisterForm>();

            NpgsqlConnection conn = new NpgsqlConnection(_connection);
            conn.Open();
            NpgsqlCommand com = new NpgsqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT * from \"register\"";
            NpgsqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                RegisterForm register = new RegisterForm()
                {
                    Name = dr["name"].ToString(),
                    Age = (int?)dr["age"],
                    Gender = dr["gender"].ToString(),
                    Province = dr["province"].ToString(),
                    District = dr["district"].ToString()

                };
                users.Add(register);
            }
            com.Dispose();
            conn.Close();
            return users;
        }
    public bool deleteUser(string name)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(_connection);
                conn.Open();
                NpgsqlCommand com = new NpgsqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.Text;
                com.CommandText = "DELETE FROM \"register\" WHERE \"name\" = @name";
                com.Parameters.AddWithValue("@name", name);
                com.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Deleting user :" + ex.Message);
                return false; 
            }
        }

        public bool updateUser(RegisterForm update)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(_connection);
                conn.Open();
                NpgsqlCommand com = new NpgsqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.Text;
                com.CommandText = "UPDATE \"register\" SET \"age\" = @age, \"gender\" = @gender, \"province\" = @province, \"district\" = @district WHERE \"name\" = @name";
                
                com.Parameters.AddWithValue("@name", update.Name ?? (object)DBNull.Value);
                com.Parameters.AddWithValue("@age", update.Age ?? (object)DBNull.Value);
                com.Parameters.AddWithValue("@gender", update.Gender ?? (object)DBNull.Value);
                com.Parameters.AddWithValue("@province", update.Province ?? (object)DBNull.Value);
                com.Parameters.AddWithValue("@district", update.District ?? (object)DBNull.Value);
                com.ExecuteNonQuery();
                MessageBox.Show($"User '{update.Name}' updated successfully!\n\n" +
                                    $"Age: {update.Age}\n" +
                                    $"Gender: {update.Gender}\n" +
                                    $"Province: {update.Province}\n" +
                                    $"District: {update.District}",
                                    "Update Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return true ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating User :" + ex.Message);
                return false;
            }

        }
    }
}
