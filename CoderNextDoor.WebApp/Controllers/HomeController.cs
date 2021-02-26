using CoderNextDoor.Data;
using CoderNextDoor.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoderNextDoor.WebApp.Controllers
{
    /// <summary>

    /// </remarks>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //   private readonly IUnitOfWork _unitOfWork;
        private Helper.Helper webApiHelper = new WebApp.Helper.Helper();

        public HttpClient _clientApiUrl;

        public HomeController(ILogger<HomeController> logger, HttpClient client)
        {
            _logger = logger;
            //    _unitOfWork = unitOfWork;
            _clientApiUrl = webApiHelper.UrlInitial();
        }

        /// <summary>
        /// Site home.
        /// </summary>
        /// <returns>
        /// View name and its view model.
        /// </returns>
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage res = await _clientApiUrl.GetAsync("/CategoryService");
            var result = res.Content.ReadAsStringAsync().Result;
            var categories = JsonConvert.DeserializeObject<List<Category>>(result);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}