using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GradAPI.Controllers
{
    public class WeatherController : Controller
    {
        static HttpClient Client = new HttpClient();

        public IActionResult Index()
        {
            var response = Client.GetAsync("https://dataservice.accuweather.com/forecasts/v1/daily/1day/331131?apikey=RF9jPHpFC8IXHNAZUGrdC9BPQO93mzI8&language=en-us&details=false&metric=false").Result;
            return new JsonResult(response.Content.ReadAsAsync<object>().Result);
        }
    }
}