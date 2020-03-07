using System;
using System.Collections.Generic;
using System.Text;

namespace CityDBTest
{
    public class City : DbEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public override string FullInfo
        {
            get { return $"{Id.ToString().PadLeft(5)}  |  {Name.PadRight(20)}  |  {CountryCode.PadLeft(4)}  |  {District.PadRight(15)}  |  {Population.ToString().PadLeft(15)}"; }
        }
    }

    public class Grid : DbEntry
    {
        public int GridID { get; set; }
        public int ColumnNum { get; set; }
        public int RowNum { get; set; }
        public int EntryNum { get; set; }

        public override string FullInfo
        {
            get { return $"{GridID.ToString().PadLeft(5, '0')}  |  {ColumnNum}  |  {RowNum}  |  {EntryNum}"; }
        }
    }



    public abstract class DbEntry
    {
        //Every entry in the database must have an id and
        //build a FullInfo property to be read
        public abstract string FullInfo { get; }

    }
}
