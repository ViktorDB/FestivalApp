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
    public class StageDA
    {
        public static ObservableCollection<Stage> GetStages()
        {
            ObservableCollection<Stage> lijst = new ObservableCollection<Stage>();

            String sSQL = "SELECT * FROM Stage";
            DbDataReader reader = Database.GetData(sSQL);
            while (reader.Read())
            {
                Stage aNieuw = new Stage();

                aNieuw.ID = reader["StageID"].ToString();
                aNieuw.Name = reader["StageName"].ToString();
                lijst.Add(aNieuw);
            }

            return lijst;
        }
    }
}