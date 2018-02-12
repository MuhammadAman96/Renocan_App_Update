using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenocanWeb.Controllers
{
    public class ClientAccountController : Controller
    {
        // GET: ClientAccount
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Client_Sign_up()
        {
            return View();
        }


        public ActionResult Client_account()
        {
            return View();

        }

       public ActionResult Client_bookmarks()
        {
            return View();

        }

      
             public ActionResult Client_activity()
        {
            return View();

        }

        public ActionResult Client_review()
        {
            return View();

        }

        
             public ActionResult Client_forgot_password()
        {
            return View();

        }

        
                  public ActionResult Client_job_request()
        {
            return View();

        }

    }
}