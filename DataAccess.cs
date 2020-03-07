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
        public List<City> GetEntries(string[] terms)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.ConnectionVal("WorldCloudDB")))
            {
                try
                {
                    var output = connection.Query<City>($"select * from {terms[0]}").ToList();
                    //var output = connection.Query<Grid>($"select * from {terms[0]} where {terms[1]} = '{terms[2]}'").ToList();
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