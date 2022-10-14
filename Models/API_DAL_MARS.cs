using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NASA_Demo.Models;

namespace NASA_Demo.Models
{
    public class API_DAL_MARS
    {
        public static HttpClient _web = null;

        public static HttpClient GetHttpClient()
        {

            if (_web == null)
            {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/v1/"); ;
            }
            return _web;
        }
        async public static Task<NasaPhotos> FindsPhotos(string rover,string date)
        {
            //string date = "2015-9-3";
            //DateTimeOffset newdate = DateTimeOffset.Parse(date);
            //string date, string rover
            HttpClient web = GetHttpClient();
            // earth_date formate for nasa API is 2010-8-11;
            //var connection = await web.GetAsync($"rovers/{rover}/photos?earth_date=2015-9-3&api_key=DEMO_KEY");
            var connection = await web.GetAsync($"rovers/{rover}/photos?earth_date={date}&api_key=DEMO_KEY");
            //var connection = await web.GetAsync($"rovers/Opportunity/photos?earth_date=2015-9-3&api_key=DEMO_KEY");

            NasaPhotos nasa = await connection.Content.ReadAsAsync<NasaPhotos>();
            


            return nasa;
        }
        //async public static Task<>



    }
}
