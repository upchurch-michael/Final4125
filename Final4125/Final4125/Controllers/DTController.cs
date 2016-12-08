using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;

namespace Final4125.Controllers
{

    public ActionResult Index()
    {
        return View();
    }

    public class DTController : Controller
    {

        public static void Today()
        {
            
            String[] names = { "en-US" };
            
            DateTime dateValue = new System.DateTime(2013, 5, 28, 10, 30, 15);

           
            foreach (var name in names)
            {
                
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(name);
               
                Console.WriteLine("Time Now is: {0}", CultureInfo.CurrentCulture.Name);
                Console.WriteLine("Date: {0:G}", dateValue);
                       
            }
        }
        // GET: DT
      
      
    }
}