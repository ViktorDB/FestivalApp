using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortableclassEvent;
using System.Web.Http;

namespace WindowsStoreEvent.Rest.Controllers
{
    public class LineUpController : ApiController
    {
        public IEnumerable<LineUp> Get()
        {
            return Models.LineUpDA.GetLineUp();
        }

    }
}
