﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using FormValidateDemo.Models;
using FormValidateDemo.Models.ViewModels;

namespace FormValidateDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(string lang = "en")
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
			var formViewModel = new IndexViewModel()
			{
				Form = new RegisterForm()
			};
			return View(formViewModel);
		}

		[HttpPost]
		public ActionResult Register(RegisterForm registerForm)
		{
			var modelStateIsValid = ModelState.IsValid;
			return Json(modelStateIsValid, JsonRequestBehavior.AllowGet);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}