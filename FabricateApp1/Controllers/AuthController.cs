using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FabricateApp1.Models;
using System.Net.Http;
using System.Linq;
using System;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace FabricateApp1.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //GET: api/Auth
        public ActionResult Auth()
        {
            IEnumerable<string> str= null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5021/api/");
                var responseTank = client.GetAsync("Auth");
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<string>>();
                    readJob.Wait();
                    str = readJob.Result;
                }
                else
                {
                    str = Enumerable.Empty<string>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(str);
        }
        
        //HttpPost("authenticate")
        public ActionResult Verify(UserCred user)
        {
            using (var client = new HttpClient())
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}