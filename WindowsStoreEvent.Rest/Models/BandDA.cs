using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBHelper;
using System.Collections.ObjectModel;
using System.Data.Common;
using PortableclassEvent;

namespace WindowsStoreEvent.Rest.Models
{
    public class BandDA
    {
        public static ObservableCollection<Band> GetBands()
        {
            ObservableCollection<Band> lijst = new ObservableCollection<Band>();

            String sSQL = "SELECT * FROM Band";
            DbDataReader reader = Database.GetData(sSQL);
            while (reader.Read())
            {
                Band aNieuw = new Band();

                aNieuw.ID = reader["IDBand"].ToString();
                int NieuwId = Convert.ToInt32(reader["IDBand"]);
                aNieuw.Description = reader["Description"].ToString();
                aNieuw.Name = reader["BandName"].ToString();
                aNieuw.Picture = reader["Picture"].ToString();
                aNieuw.Facebook = reader["Facebook"].ToString();
                aNieuw.Twitter = reader["Twitter"].ToString();
                //aNieuw.Genres = reader["Genres"];


                //SELECT * FROM Band INNER JOIN Band_Genre ON Band.ID = Band_Genre.BandID INNER JOIN Genre ON Genre.ID = Band_Genre.GenreID WHERE BandID = {0}


            //    String sSQLJOIN = "SELECT * FROM Band INNER JOIN Band_Genre ON Band.IDBand = Band_Genre.BandID INNER JOIN Genre ON Genre.ID = Band_Genre.GenreID WHERE BandID = {0}";
            //    string data = Convert.ToString(NieuwId);
            //    string sSQLGenre = string.Format(sSQLJOIN, data);
            //    DbDataReader readerGenre = Database.GetData(sSQLGenre);

            //    aNieuw.Genres = new ObservableCollection<Genre>();

            //    while (readerGenre.Read())
            //    {
            //        Genre aNieuwType = new Genre();
            //        aNieuwType.ID = readerGenre["GenreID"].ToString();
            //        aNieuwType.Name = readerGenre["GenreName"].ToString();


            //        aNieuw.Genres.Add(aNieuwType);
            //    }
            //    lijst.Add(aNieuw);
            }

            return lijst;
        }
    }
}