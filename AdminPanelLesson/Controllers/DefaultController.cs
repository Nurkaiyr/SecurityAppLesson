using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AdminPanelLesson.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            return File(@"C:\Users\едиген.CORP\Downloads\MobApp-colorlib.zip", "application/zip");
        }
    }
}