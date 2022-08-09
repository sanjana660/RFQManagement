using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FabricateApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace FabricateApp1.Controllers
{
    
    public class PlantController : Controller
    {
        //GET: GetAllParts
        public ActionResult Index1()
        {
            IEnumerable<Part> part = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var responseTank = client.GetAsync("Plant/GetAllPartDetails");
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Part>>();
                    readJob.Wait();
                    part = readJob.Result;
                }
                else
                {
                    part = Enumerable.Empty <Part>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(part);
        }

        public ActionResult AddParts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddParts(Part part)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var postJob = client.PostAsJsonAsync<Part>("Plant/addParts", part);
                postJob.Wait();

                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index1");
            }

            ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin");
            return View(part);
        }

        public ActionResult AddPartReorder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPartReorder(PlantReorderDetails reorderdetails)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var postJob = client.PostAsJsonAsync<PlantReorderDetails>("Plant/addPartreorder", reorderdetails);
                postJob.Wait();

                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("getReorder");
            }

            ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin");
            return View(reorderdetails);
        }

        //GET: get()
        public ActionResult Index()
        {
            IEnumerable<PlantReorderDetails> plantreorderdetails = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var responseTank = client.GetAsync("Plant/get");
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<PlantReorderDetails>>();
                    readJob.Wait();
                    plantreorderdetails = readJob.Result;
                }
                else
                {
                    plantreorderdetails = Enumerable.Empty<PlantReorderDetails>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(plantreorderdetails);
        }

        //GET: getReorder()
        public ActionResult getReorder()
        {
            IEnumerable<PlantReorderDetails> plantreorderdetails = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var responseTank = client.GetAsync("Plant/getReorder");
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<PlantReorderDetails>>();
                    readJob.Wait();
                    plantreorderdetails = readJob.Result;
                }
                else
                {
                    plantreorderdetails = Enumerable.Empty<PlantReorderDetails>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(plantreorderdetails);
        }

        //GET: stockinHand {PartId}
        public ActionResult stockinhand(int id)
        {
            Part stockinhand = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var responseTask = client.GetAsync($"Plant/{id}");
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<Part>();
                    readJob.Wait();
                    stockinhand = readJob.Result;
                }
             }
            return View(stockinhand);
        }

        //Create an action for getting data by id for edit/Update min max form
        public ActionResult Putminmax(int id, int min, int max)
        {
            ReorderRules minmax = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var responseTask = client.GetAsync($"Plant/Putminmax?id=" + id + "&min=" + min + "&max=" + max);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ReorderRules>();
                    readTask.Wait();
                    minmax = readTask.Result;
                }
            }
            return View(minmax);
        }
        public ActionResult UpdateObj()
        {
            return View();
        }

        //Create a post method to update the data
        [HttpPost]
        public ActionResult UpdateObj(ReorderRules reorderRules)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5004/api/");
                var putTask = client.PutAsJsonAsync<ReorderRules>("Plant/getReorder", reorderRules);
                putTask.Wait();
                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                return View(reorderRules);
            }
        }


    }

}
