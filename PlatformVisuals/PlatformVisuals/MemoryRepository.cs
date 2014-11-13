using PlatformVisuals.Models;
using SQLite.Net;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatformVisuals
{
    public class PersonRepository
    {
        private SQLiteConnection dbConn;
        
        public string StatusMessage { get; set; }

        public PersonRepository(ISQLitePlatform sqlitePlatform, string dbPath)
        {
            //initialize a new SQLiteConnection 
            if (dbConn == null)
            {
                dbConn = new SQLiteConnection(sqlitePlatform, dbPath);

                //create the Person table
                dbConn.CreateTable<Memory>();
            }
        }
        
        public void InsertPosition(int position)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
//                if (string.IsNullOrEmpty(position))
//                    throw new Exception("Valid name required");

                //insert a new person into the Person table
                result = dbConn.Insert(new Memory { Position = position});
                StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, position);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", position, ex.Message);
            }

        }

		public void InsertValue(int value)
		{
			int result = 0;
			try
			{
				//basic validation to ensure a name was entered
				//                if (string.IsNullOrEmpty(position))
				//                    throw new Exception("Valid name required");

				//insert a new person into the Person table
				result = dbConn.Insert(new Memory { Value = value});
				StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, position);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", position, ex.Message);
			}

		}



        public List<Memory> GetAllPeople()
        {
            //return a list of people saved to the Person table in the database
            return dbConn.Table<Memory>().ToList();
        }
        
    }
}
