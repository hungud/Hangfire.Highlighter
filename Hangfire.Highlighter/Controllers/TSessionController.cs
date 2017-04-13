using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Hangfire.Highlighter.Controllers
{
    public class TSessionController : Controller
    {
        // GET: TSession
        public ActionResult Index()
        {
            var task = Task.Run(() => {

                var t = 0;

                for(var idx = 0; idx < 10000; idx++)
                {
                    t += idx;
                }
                
                Session["T"] = t;

            });

            //Session.Add("task", task);

            return View();
        }

        public ActionResult TestResult()
        {
            return View();
        }

    }
}