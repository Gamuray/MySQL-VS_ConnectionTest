using System;
using System.Collections.Generic;

namespace CityDBTest
{
 
    public class Controller
    {
        


        public List<City> SearchByDistrict(string[] searchTerms, DataAccess db, List<City> entries)
        {
           return entries = db.GetEntries(searchTerms[0], searchTerms[1], searchTerms[2]);
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