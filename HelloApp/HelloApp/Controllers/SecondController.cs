using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecondController : ControllerBase
    {
        RegisterHelloBL _registerHelloBL;

        public SecondController(RegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet]
        public string Get()
        {
            return _registerHelloBL.Registration("Value from second controller ->");

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        //[HttpGet]
        //[Route("Second")]
        //public string Get2()
        //{
        //    return "My Hello App second get";

        //}
    }
}