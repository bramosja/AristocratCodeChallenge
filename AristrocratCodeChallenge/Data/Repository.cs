using AristrocratCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AristrocratCodeChallenge.Data
{
    //contains all database interactions
    class Repository
    {
        public SqlConnection Connection
        {
            get
            {
                // This is "address" of the database
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AristocratDB;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }

        //this function returns a list of Employees based on the Id of the company that they belong to
        public List<Employee> GetEmployeeByDepartment(int companyId)
        {
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $@"SELECT e.employeeId, e.name, p.positionId, p.description 
                                            FROM employee e 
                                            INNER JOIN position p ON e.positionid = p.positionid 
                                        WHERE e.companyid = @companyId";
                    cmd.Parameters.Add(new SqlParameter("@companyId", companyId));
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Employee> employees = new List<Employee>();

                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            EmployeeId = reader.GetInt32(reader.GetOrdinal("employeeId")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Position = new Position
                            {
                                PositionId = reader.GetInt32(reader.GetOrdinal("positionId")),
                                Description = reader.GetString(reader.GetOrdinal("description"))
                            }
                        };

                        employees.Add(employee);
                    }

                    reader.Close();

                    return employees;
                }
            };
        }
    }
}
