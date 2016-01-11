using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseBLL _iBaseBll;

        /// <summary>
        /// 构造方法注入依赖接口
        /// </summary>
        /// <param name="iBaseBll"></param>
        public HomeController(IBLL.IBaseBLL iBaseBll)
        {
            _iBaseBll = iBaseBll;
        }

        // GET: Home
        public ActionResult Index()
        {


            return View();
        }
    }
}