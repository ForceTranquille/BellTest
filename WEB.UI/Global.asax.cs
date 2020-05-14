using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace WEB.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Config Mapper instance de basededonnee et modele
            AutoMapper.Mapper.CreateMap<DAL.Ticket, WEB.UI.Models.TicketEditee>();
            //Inverser
            AutoMapper.Mapper.CreateMap<WEB.UI.Models.TicketEditee, DAL.Ticket>();
        }
    }
}
