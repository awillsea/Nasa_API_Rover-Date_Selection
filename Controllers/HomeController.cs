using Microsoft.AspNetCore.Mvc;
using NASA_Demo.Models;
using System.Diagnostics;

namespace NASA_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

         async public Task<IActionResult> Index()
        {
            //NasaPhotos nasa = await API_DAL_MARS.FindsPhotos("curiosity", "2015-9-3");
            //HttpClient web = new HttpClient();
            //web.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/v1/");
            //var connection = await web.GetAsync($"rovers/Opportunity/photos?earth_date=2015-6-3&api_key=DEMO_KEY");


            
            //    NasaPhotos nasa = await connection.Content.ReadAsAsync<NasaPhotos>();
                return View();
           
               
            
       
        }
        async public Task<IActionResult> GetPhotos(string rover,string earth_date)
        {
            NasaPhotos nasa = await API_DAL_MARS.FindsPhotos(rover, earth_date);
            ViewBag.date = earth_date;
            return View(nasa);
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