using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index()
        {
            string path = HostingEnvironment.MapPath("~/static/index.html");
            var response = new HttpResponseMessage();
            response.Content = new StringContent(System.IO.File.ReadAllText(path));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}