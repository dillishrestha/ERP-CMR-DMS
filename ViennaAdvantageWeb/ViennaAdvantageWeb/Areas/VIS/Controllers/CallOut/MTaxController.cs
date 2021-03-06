﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using VAdvantage.Model;
using VAdvantage.Utility;
using VIS.Models;

namespace VIS.Controllers
{
    public class MTaxController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult CalculateTax(string fields)
        {
            
            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MTaxModel tax = new MTaxModel();
                retJSON = JsonConvert.SerializeObject(tax.CalculateTax(ctx,fields));
            }          
            return Json(retJSON, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Get(string fields)
        {            
            
            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MTaxModel tax = new MTaxModel();
                retJSON = JsonConvert.SerializeObject(tax.Get(ctx, fields));
            }         

            return Json(retJSON, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Get_Tax_ID(string fields)
        {
           
            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MTaxModel tax = new MTaxModel();
                retJSON = JsonConvert.SerializeObject(tax.Get_Tax_ID(ctx, fields));
            }         
            return Json(retJSON, JsonRequestBehavior.AllowGet);
        }
    }
}