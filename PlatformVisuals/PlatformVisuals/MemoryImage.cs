using PlatformVisuals.Models;
using SQLite.Net;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PlatformVisuals
{
    public class MemoryImage
    {

        private SQLiteConnection dbConn;
        
        public string StatusMessage { get; set; }

        public MemoryImage(ISQLitePlatform sqlitePlatform, string dbPath)
        {
            //initialize a new SQLiteConnection 
            if (dbConn == null)
            {
                dbConn = new SQLiteConnection(sqlitePlatform, dbPath);

                //create the Person table
            //    dbConn.CreateTable<Memory>();
				dbConn.DropTable<TBImage> ();
				dbConn.CreateTable<TBImage>();
            }
        }

		public void InsertValue(int value, string img)
		{
			try
			{
				dbConn.Insert(new TBImage {Value = value , Img = img});
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", value, ex.Message);
			}

		}

		public TBImage SelectValue(int value)
		{

			TBImage retorno = new TBImage();

			try
			{
				retorno = dbConn.Get<TBImage>(value);
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
				dbConn.DeleteAll<TBImage>();
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
				dbConn.DropTable<TBImage>();
				//StatusMessage = string.Format("{0} record(s) added [Position: {1})", result, value);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to drop table {0}",ex.Message);
			}
				

		}
			
    }
}
