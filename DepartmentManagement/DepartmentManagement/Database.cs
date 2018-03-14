using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DepartmentManagement.Entities;
using DepartmentManagement.Properties;

namespace DepartmentManagement
{
    public class Database
    {
        private string connString;

        public Database()
        {
            connString = Settings.Default.ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        public void CreateTask(string departmentName, decimal mgrSSN)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insertDepartment")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                cmd.Parameters.Add(new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 150));
                cmd.Parameters.Add(new SqlParameter("@ManagerSSN", SqlDbType.Decimal));

                cmd.Parameters["@DepartmentName"].Value = departmentName;
                cmd.Parameters["@ManagerSSN"].Value = mgrSSN;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert succesfull");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not insert");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public void RemoveTask(string name)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlDataReader rdr = null;
                string readQuery = "Select * from DailyTask Where Name = '" + name + "'";
                SqlCommand readSqlCommand = new SqlCommand(readQuery);
                readSqlCommand.Connection = sqlConnection;
                rdr = readSqlCommand.ExecuteReader();
                List<string> strings = new List<string>();
                while (rdr.Read())
                {
                    strings.Add((string)rdr["Name"]);
                }
                rdr.Close();
                if (strings.Count > 0)
                {
                    var itemToRemove = strings.FirstOrDefault();
                    string deleteQuery = "DELETE TOP(1) FROM dailytask Where Name = '" + itemToRemove + "'";
                    SqlCommand deleteSqlCommand = new SqlCommand(deleteQuery);
                    deleteSqlCommand.Connection = sqlConnection;
                    deleteSqlCommand.ExecuteNonQuery();
                }
            }
        }

        public List<Department> ReadAllDepartments()
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand("getAllDepartments")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                List<Department> departments = new List<Department>();
                using (reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        var d = new Department()
                         { DName = (string)reader[0], DNumber = reader.GetInt32(1),
                             MgrSSN = (decimal)reader[2], MgrStartDate = reader.GetDateTime(3)

                        };
                        departments.Add(d);
                    }
                }

                reader.Close();
                return departments;
            }
        }

        public void UpdateDepartmentName(int deptnum, string name)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("updateDepartmentName")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                cmd.Parameters.Add(new SqlParameter("@DNum", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Dname", SqlDbType.NVarChar));

                cmd.Parameters["@DNum"].Value = deptnum;
                cmd.Parameters["@Dname"].Value = name;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update succesfull");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update " + e.InnerException);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public void UpdateManagerForDepartment(int deptnum, decimal ssn)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("updateDepartmentManager")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                cmd.Parameters.Add(new SqlParameter("@DNum", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@MgrSSN", SqlDbType.Decimal));

                cmd.Parameters["@DNum"].Value = deptnum;
                cmd.Parameters["@MgrSSN"].Value = ssn;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update succesfull");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public Department ReadDepartment(int id)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand("getDepartment")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                cmd.Parameters.Add(new SqlParameter("@DepartmentNum", SqlDbType.Int));

                cmd.Parameters["@DepartmentNum"].Value = id;
                List<Department> departments = new List<Department>();
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var d = new Department()
                        {
                            DName = (string)reader[0],
                            DNumber = reader.GetInt32(1),
                            MgrSSN = (decimal)reader[2],
                            MgrStartDate = reader.GetDateTime(3)

                        };
                        departments.Add(d);
                    }
                }

                reader.Close();
                return departments.Count == 0 ? null : departments[0];
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("deleteDepartment")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection = sqlConnection;
                cmd.Parameters.Add(new SqlParameter("@DepartmentNum", SqlDbType.Int));
                cmd.Parameters["@DepartmentNum"].Value = id;

                cmd.ExecuteNonQuery();
            }

        }
    }
}
