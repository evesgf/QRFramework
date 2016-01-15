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
        private readonly IUsersBLL _iUsersBll;

        /// <summary>
        /// 构造方法注入依赖接口
        /// </summary>
        /// <param name="iBaseBll"></param>
        public HomeController(IUsersBLL iUsersBll)
        {
            _iUsersBll = iUsersBll;
        }

        // GET: Home
        public ActionResult Index()
        {
            var a=_iUsersBll.Hello();

            return View();
        }
    }
}