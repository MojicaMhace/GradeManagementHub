<<<<<<< HEAD
﻿using GradeHub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 51d7bec4d946c828bad4dbb5039cd99aa3aeb77f

namespace GradeHub.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
<<<<<<< HEAD
        public async Task<IActionResult> Index()
        {
            string apiUrl = "https://localhost:7198/api/user";
            List<Credentials> credentials = new List<Credentials>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode) 
                {
                    var result = await response.Content.ReadAsStringAsync();
                    credentials = JsonConvert.DeserializeObject<List<Credentials>>(result);
                }
            }

            return View(credentials);
        }


=======
        public ActionResult Index()
        {
            return View();
        }

>>>>>>> 51d7bec4d946c828bad4dbb5039cd99aa3aeb77f
        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<ActionResult> Create(Credentials credentials)
        {
            string apiUrl = "https://localhost:1257/api/user";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(credentials);
=======
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
>>>>>>> 51d7bec4d946c828bad4dbb5039cd99aa3aeb77f
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
