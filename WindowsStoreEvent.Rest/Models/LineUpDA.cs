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
    public class LineUpDA
    {
        public static ObservableCollection<LineUp> GetLineUp()
        {
            ObservableCollection<LineUp> lijst = new ObservableCollection<LineUp>();

            String sSQL = "SELECT LineUp.*, Stage.*, Band.* FROM Band INNER JOIN LineUp ON Band.IDBand = LineUp.Band INNER JOIN Stage ON LineUp.Stage = Stage.StageID";
            DbDataReader reader = Database.GetData(sSQL);
            while (reader.Read())
            {
                LineUp aNieuw = new LineUp();

                aNieuw.ID = reader["ID"].ToString();
                aNieuw.Date = Convert.ToDateTime(reader["Date"]);   
                aNieuw.From = reader["From"].ToString();
                aNieuw.Until = reader["Until"].ToString();
                aNieuw.Stage = reader["Stage"].ToString();
                aNieuw.Band = reader["Band"].ToString();

                //aNieuw.Stage.ID = reader["StageID"].ToString();
                //aNieuw.Stage.Name = reader["StageName"].ToString();

                //aNieuw.Band.ID = reader["BandID"].ToString();
                //aNieuw.Band.Name = reader["BandName"].ToString();
                //aNieuw.Band.Picture = reader["Picture"].ToString();
                //aNieuw.Band.Description = reader["Description"].ToString();

                String sqlgenre = "SELECT * FROM Stage WHERE StageID = {0}";
                string data = aNieuw.Stage;
                string sSQLGenre = string.Format(sqlgenre, data);
                DbDataReader readerStage = Database.GetData(sSQLGenre);

                aNieuw.CStage = new Stage();

                while (readerStage.Read())
                {
                    Stage aNieuwStage = new Stage();
                    aNieuwStage.ID = readerStage["StageID"].ToString();
                    aNieuwStage.Name = readerStage["StageName"].ToString();


                    aNieuw.CStage = aNieuwStage;
                }


                String sqlSband = "SELECT * FROM Band WHERE IDBand = {0}";
                string data1 = aNieuw.Band;
                string sqlBand = string.Format(sqlSband, data1);
                DbDataReader readerBand = Database.GetData(sqlBand);

                aNieuw.CBand = new Band();

                while (readerBand.Read())
                {
                    Band aNieuwBand = new Band();
                    aNieuwBand.ID = readerBand["IDBand"].ToString();
                    aNieuwBand.Name = readerBand["BandName"].ToString();
                    aNieuwBand.Picture = readerBand["Picture"].ToString();
                    aNieuwBand.Description = readerBand["Description"].ToString();


                    aNieuw.CBand = aNieuwBand;
                }

                lijst.Add(aNieuw);
            }

            return lijst;
        }
    }
}