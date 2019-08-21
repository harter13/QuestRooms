using QuestRooms.BLL.Servises.Abstraction;
using QuestRooms.BLL.Servises.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        private readonly ICitiesService cityService;

        public TestController()
        {
            cityService = new CitiesServis();
        }

        public ActionResult Index()
        {
        }
    }
}