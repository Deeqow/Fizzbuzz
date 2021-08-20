using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult FizzBuzzPage()
        {
            //view for input values
            return View();
        }

        // POST: FizzBuzz 
        [HttpPost]       
        public ActionResult DisplayFizzBuzz(FormCollection myform)
        {
            try
            {
                string arrStr = myform["txtid"].ToString();               
                ViewBag.myValues = FizzBuzz(arrStr);                                   
                return PartialView("FizzBuzzPage");
            }
            catch
            {
                return RedirectToAction("FizzBuzzPage");
            }
        }

        // Function to Display Fizz Buzz data
        [NonAction]
        private string FizzBuzz(string arrayValues)
        {
            int result;
            bool flag = false;
            string[] values = arrayValues.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var value in values)
            {
                flag = int.TryParse(value, out result);

                if (flag)
                {
                    if (result % 3 == 0 && result % 5 == 0)
                    {
                        sb.AppendLine("FizzBuzz");
                    }
                    else if (result % 3 == 0)
                    {
                        sb.AppendLine($"Fizz");
                    }
                    else if (result % 5 == 0)
                    {
                        sb.AppendLine($"Buzz");
                    }
                    else
                    {
                        sb.AppendFormat("Divided {0} by 3\n", result);
                        sb.AppendFormat("Divided {0} by 5\n", result);
                    }
                }
                else
                {
                    sb.AppendLine("Invalid Item");
                }               
            }
            return sb.ToString();
        }

    }
}
