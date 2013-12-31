using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableclassEvent
{
    public class LineUp
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string until;

        public string Until
        {
            get { return until; }
            set { until = value; }
        }

        private String stage;

        public String Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        private String band;

        public String Band
        {
            get { return band; }
            set { band = value; }
        }

        private Stage cstage;

        public Stage CStage
        {
            get { return cstage; }
            set { cstage = value; }
        }

        private Band cband;

        public Band CBand
        {
            get { return cband; }
            set { cband = value; }
        }
    }
}
