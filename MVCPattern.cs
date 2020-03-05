using System;
using System.Collections.Generic;

namespace CityDBTest
{
    class MvcPattern
    {
        

        static void Main(string[] args)
        {
            List<City> _entries = new List<City>();
            DataAccess _db = new DataAccess();
            Controller controller = new Controller();

            string[] searchTerms = new string[3];
            Console.WriteLine("Table: ");
            searchTerms[0] = Console.ReadLine();
            Console.WriteLine("Column: ");
            searchTerms[1] = Console.ReadLine();
            Console.WriteLine("Restriction: ");
            searchTerms[2] = Console.ReadLine();

            _entries = controller.SearchByDistrict(searchTerms, _db, _entries);
            controller.PrintList(_entries);
        }






    }
}
