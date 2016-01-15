using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using MyFrameWork.DAL;
using MyFrameWork.Entitys;
using MyFrameWork.IDAL;
using MyFrameWork.Migrations;

namespace MyFrameWork.Controllers
{
    public class HomeController : Controller
    {
        EFDBContext db = new EFDBContext();
        private readonly IUserInfoDAL _iuserInfoDal;
        private readonly IUsersBLL _usersBll;

        public HomeController(IUserInfoDAL iuserinfodal,IUsersBLL usersBll)
        {
            _iuserInfoDal = iuserinfodal;
            _usersBll = usersBll;
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

            var list = _iuserInfoDal.GetListBy(a=>a.Id==1,b=>b.Id).ToList();
            #endregion

            return View(list);
        }
    }
}