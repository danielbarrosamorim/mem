using PlatformVisuals.Models;
using SQLite.Net;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatformVisuals
{
    public class MemoryRepository
    {


        private SQLiteConnection dbConn;
        
        public string StatusMessage { get; set; }

        public MemoryRepository(ISQLitePlatform sqlitePlatform, string dbPath)
        {
            //initialize a new SQLiteConnection 
            if (dbConn == null)
            {
                dbConn = new SQLiteConnection(sqlitePlatform, dbPath);

                //create the Person table
            //    dbConn.CreateTable<Memory>();
				dbConn.DropTable<MemoryRand> ();
				dbConn.CreateTable<MemoryRand>();
            }
        }
        
//        public void InsertPosition(int position)
//        {
//            int result = 0;
//            try
//            {
//                //basic validation to ensure a name was entered
////                if (string.IsNullOrEmpty(position))
////                    throw new Exception("Valid name required");
//
//                //insert a new person into the Person table
//                result = dbConn.Insert(new Memory { Position = position});
//                StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, position);
//            }
//            catch (Exception ex)
//            {
//                StatusMessage = string.Format("Failed to add {0}. Error: {1}", position, ex.Message);
//            }
//
//        }

		public void InsertValue(int value)
		{
			try
			{
				//insert a new person into the Memory_Rand table
				dbConn.Insert(new MemoryRand {Value = value});
				//StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, value);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", value, ex.Message);
			}

		}

		public MemoryRand SelectValue(int value)
		{

			MemoryRand retorno = new MemoryRand();

			try
			{
				//Get a new Memory_Rand row

				retorno = dbConn.Get<MemoryRand>(value);
				//StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, value);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", value, ex.Message);
			}

			return retorno;

		}

		public void DeleteAllValues ()
		{

			try
			{
				//insert a new person into the Memory_Rand table
				dbConn.DeleteAll<MemoryRand>();
				//StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, value);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to delete table {0}",ex.Message);
			}


		}

		public void DropTable ()
		{

			try
			{
				//insert a new person into the Memory_Rand table
				dbConn.DropTable<MemoryRand>();
				//StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, value);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to drop table {0}",ex.Message);
			}
				

		}
			
    }
}
