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
            //Console.WriteLine("Table: ");
            searchTerms[0] = "city";
                //Console.ReadLine();
            Console.WriteLine("Enter search category : ");
            searchTerms[1] = Console.ReadLine();
            Console.WriteLine("Enter your search restriction: ");
            searchTerms[2] = Console.ReadLine();

            _entries = controller.SearchByTerms(searchTerms, _db);
            //controller.PrintList(_entries);
        }






    }
}
