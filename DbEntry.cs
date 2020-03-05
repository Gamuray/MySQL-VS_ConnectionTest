using System;
using System.Collections.Generic;
using System.Text;

namespace CityDBTest
{
    public class City : DbEntry
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public override string FullInfo
        {
            get { return $"{Name} {CountryCode} {District} ({Population})"; }
        }
    }



    public abstract class DbEntry
    {
        //Every entry in the database must have an id and
        //build a FullInfo property to be read
        public abstract int Id { get; set; }
        public abstract string FullInfo { get; }

    }
}
