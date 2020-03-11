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




                    var output2 = connection.Query<>($"select * from {terms[0]}");

                    var col1 = output2.Read<string>().ToList();
                    var col2 = output2.Read<string>().ToList();

                    Console.WriteLine(col1[0] + " " + col2[0] + "\n" + col1[1] + " " + col2[1]);
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