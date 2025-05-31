// LashaMurgvaLominadzeShraieri.Final.Services/SqlCarService.cs
using LashaMurgvaLominadzeShraieri.Final.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LashaMurgvaLominadzeShraieri.Final.Services
{
    public class SqlCarService
    {
        private readonly string _connectionString;

        public SqlCarService()
        {
            // IMPORTANT: Replace "YourPassword123!" with your actual SQL Server password.
            _connectionString = "Server=localhost,1433;Database=CarDatabase;User Id=sa;Password=YourPassword123;TrustServerCertificate=True;";
        }

        public void AddCar(Car car)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Cars (Model, Weight, Speed) VALUES (@Model, @Weight, @Speed)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Weight", car.Weight);
                    command.Parameters.AddWithValue("@Speed", car.Speed);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCar(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Cars WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCar(Car updatedCar)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Cars SET Model = @Model, Weight = @Weight, Speed = @Speed WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Model", updatedCar.Model);
                    command.Parameters.AddWithValue("@Weight", updatedCar.Weight);
                    command.Parameters.AddWithValue("@Speed", updatedCar.Speed);
                    command.Parameters.AddWithValue("@Id", updatedCar.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Model, Weight, Speed FROM Cars";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(new Car(
                                model: reader["Model"].ToString(),
                                weight: Convert.ToDouble(reader["Weight"]),
                                speed: Convert.ToInt32(reader["Speed"])
                            )
                            { ID = Convert.ToInt32(reader["Id"]) });
                        }
                    }
                }
            }
            return cars;
        }
    }
}
