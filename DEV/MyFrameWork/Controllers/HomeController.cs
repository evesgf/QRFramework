using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFrameWork.DAL;
using MyFrameWork.Entitys;
using MyFrameWork.IBLL;
using MyFrameWork.Migrations;

namespace MyFrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHlelloBLL _iHlelloBll;
        private readonly IUsersBLL _iUsersBll;
        private readonly IUserInfoBLL _iuserInfoBll;

        public HomeController(IHlelloBLL iHlelloBll, IUsersBLL iUsersBll, IUserInfoBLL iuserInfoBll)
        {
            _iHlelloBll = iHlelloBll;
            _iUsersBll = iUsersBll;
            _iuserInfoBll = iuserInfoBll;
        }

        // GET: Home
        public ActionResult Index()
        {
            //#region 插入数据

            //var userinfo = new UserInfo
            //{
            //    RealName = "RealName",
            //    Age = 1,
            //    Sex = 1
            //};
            //var user = new Users
            //{
            //    UserName = "UserName",
            //    PassWord = "123456",
            //    UserInfo = userinfo
            //};
            //db.Users.Add(user);
            //db.SaveChanges();
            //#endregion

            #region 查询list

            var a = _iUsersBll.Users();
            var b = _iHlelloBll.Hello();
            var c = _iuserInfoBll.Show();
            #endregion

            return View();
        }
    }
}