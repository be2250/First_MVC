using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI_2020_1029.Controllers
{
    public class LoginController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
      
        public IActionResult PartView_Login(string sumbit)
        {
            if (sumbit == "sumbit")
            {
                //按鈕接值設
                //回傳該頁主頁
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                //維持在Login 畫面
                return View();
            }
           
        }
   
    }
}
