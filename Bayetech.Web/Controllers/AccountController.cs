﻿using System;
using System.Web.Http;
using Bayetech.Service;
using Newtonsoft.Json.Linq;
using Bayetech.Service.IServices;

namespace Bayetech.Web.Controllers
{
    public class AccountController : BaseController
    {

        //取出服务层
        ILoginSignService service = ctx.GetObject("LoginSignService") as ILoginSignService;

        [HttpGet]
        public bool CheckAccount(string accountName)
        {
            try
            {
                return service.CheckAccount(accountName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public bool CreatAccount(JObject json)
        {
            try
            {
                return service.CreatAccount(json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public JObject LoginIn(JObject json)
        {
            try
            {
                return service.CheckLogin(json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
