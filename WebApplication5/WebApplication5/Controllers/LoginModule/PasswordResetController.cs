using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebMatrix.WebData;

namespace WebApplication5.Controllers.LoginModule
{
    public class PasswordResetController : Controller
    {
        // GET: PasswordReset
        [HttpGet]
        public ActionResult GetPasswordform()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult GetPasswordform(Passwordresetmodel reset)
        {
            var data = TempData["mydata"] as string;
            
            if (reset.Token == data )
            {
                

                WebSecurity.ResetPassword(reset.Token, reset.newPassword);
                return RedirectToAction("Index","Login");
            }
            else
            {
                ModelState.AddModelError("", "username is incorrect Please enter valid username");
            }
            return View();
        }
    }
}