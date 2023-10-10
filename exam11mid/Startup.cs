using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(exam11mid.Startup))]

namespace exam11mid
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.MapSignalR();
        }
    }
}
