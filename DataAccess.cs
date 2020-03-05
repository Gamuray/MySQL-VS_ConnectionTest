using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;

namespace CityDBTest
{
    public class DataAccess
    {
        public List<City> GetEntries(string table, string column, string restriction)
        {
            //MySql.Data.MySqlClient.MySqlConnectionStringBuilder mySqlConnection;
            //mySqlConnection = new MySqlConnectionStringBuilder(Helper.ConnectionVal("WorldDB"));
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal("WorldDB")))
            using (MySqlConnection connection = new MySqlConnection(Helper.ConnectionVal("WorldDB")))
            {
                try
                {
                    var output = connection.Query<City>($"select * from {table} where {column} = '{restriction}'")
                        .ToList();
                    return output;
                }
                catch(NullReferenceException)
                {
                    return null;
                }

                
            }

            
        }
    }
}