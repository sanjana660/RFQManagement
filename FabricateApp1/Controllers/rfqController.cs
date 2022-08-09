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
using System.Net.Http.Json;

namespace FabricateApp1.Controllers
{
    
    public class rfqController : Controller
    {
        //GET: GetRfq
        public ActionResult Index()
        {
            IEnumerable<Rfq> rfq = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5006/api/");
                var responseTank = client.GetAsync("rfq/GetRFQ");
                
                responseTank.Wait();

                var result = responseTank.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Rfq>>();
                    readJob.Wait();
                    rfq = readJob.Result;
                }
                else
                {
                    rfq = Enumerable.Empty<Rfq>();
                    ModelState.AddModelError(string.Empty, "Server error occured");
                }
            }
            return View(rfq);
        }

        //GET: Id
        public ActionResult GetRfqbyId(int id)
        {
            Rfq rfq = new Rfq();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5006/api/");
                var responseTask = client.GetAsync($"rfq/{id}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<Rfq>();
                    readJob.Wait();
                    rfq = readJob.Result;
                }
            }
            return View(rfq);
        }

        //GET: GetFeedback
        public ActionResult GetFeedback(int id)
        {
            Supplier supplier = new Supplier();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5006/api/");
                var responseTask = client.GetAsync($"rfq/GetFeedback/{id}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));


                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<Supplier>();
                    readJob.Wait();
                    supplier = readJob.Result;
                }
               
            }
            return View(supplier);
        }

    }
}
