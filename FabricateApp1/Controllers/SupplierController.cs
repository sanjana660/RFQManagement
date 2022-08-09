using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FabricateApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace FabricateApp1.Controllers
{
    
    public class SupplierController : Controller
    {
        //GET: GetAllSupplier
        public ActionResult Index()
        {
            IEnumerable<Supplier> supplier = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5002/api/");
                var responseTank = client.GetAsync("Supplier/GetAllSuppliers");
                responseTank.Wait();

                var result = responseTank.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Supplier>>();
                    readJob.Wait();
                    supplier = readJob.Result;
                }
                else
                {
                    supplier = Enumerable.Empty<Supplier>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(supplier);
        }

        //GET: GetSupplierOfPart
        public ActionResult GetSupplierOfPart()
        {
            IEnumerable<Supplier> supplier = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5002/api/");
                var responseTank = client.GetAsync("Supplier/GetSupplierOfPart");
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Supplier>>();
                    readJob.Wait();
                    supplier = readJob.Result;
                }
                else
                {
                    supplier = Enumerable.Empty<Supplier>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(supplier);
        }


        public ActionResult addSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addSupplier(Supplier supplier)
        {
           using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5002/api/");
                var postJob = client.PostAsJsonAsync<Supplier>("Supplier/addSupplier", supplier);
                postJob.Wait();

                var postResult= postJob.Result;
                if(postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin");
            return View(supplier);
        }

        //Create an action for getting data by id for edit/Update form
        public ActionResult Update(int id)
        {
            Supplier supplier = new Supplier();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5002/api/");
                var responseTask = client.GetAsync($"Supplier/Update/{id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Supplier>();
                    readTask.Wait();
                    supplier = readTask.Result;
                }
            }
            return View(supplier);
        }
     

        //Create a post method to update the data
        [HttpPost]
        public ActionResult Update(Supplier supplier)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5002/api/");
                var putTask = client.PutAsJsonAsync<Supplier>("Supplier/addSupplier", supplier);
                putTask.Wait();
                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                return View(supplier);
            }
        }
    }
}
