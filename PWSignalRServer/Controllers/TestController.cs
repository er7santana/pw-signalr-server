using Microsoft.AspNet.SignalR;
using PWSignalRServer.Hubs;
using System.Web.Http;

namespace PWSignalRServer.Controllers
{
    public class TestController : ApiController
    {
        // POST api/<controller>
        public void Post([FromBody]Retorno retorno)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hubContext.Clients.All.FalaAlgumaCoisa(retorno.Text);
        }
    }

    public class Retorno
    {
        public string Text { get; set; }
    }
}