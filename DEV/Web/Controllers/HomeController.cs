using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model.Entitys;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestBLL _iBaseBll;

        /// <summary>
        /// 构造方法注入依赖接口
        /// </summary>
        /// <param name="iBaseBll"></param>
        public HomeController(ITestBLL iBaseBll)
        {
            _iBaseBll = iBaseBll;
        }

        // GET: Home
        public ActionResult Index()
        {
            var a= _iBaseBll.Hello();

            return View();
        }
    }
}