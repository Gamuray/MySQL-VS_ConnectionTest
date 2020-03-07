using System;
using System.Collections.Generic;

namespace CityDBTest
{
 
    public class Controller
    {
        


        public List<City> SearchByTerms(string[] searchTerms, DataAccess db)
        {
           return db.GetEntries(searchTerms);
        }

        public void PrintList(List<City> entries)
        {
            if (entries == null)
            {
                Console.WriteLine("No Data.");
                return;
            }
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.FullInfo);
            }
        }
    }
}