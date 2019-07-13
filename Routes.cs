using Orchard.Mvc.Routes;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace Codesanook.PrivacyPolicy
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
            {
                routes.Add(routeDescriptor);
            }
        }

        private IEnumerable<RouteDescriptor> GetRoutes()
        {
            const string areaName = "CodeSanook.PrivacyPolicy";
            return new[] {
                new RouteDescriptor {
                    Name = "PrivacyPolicy",
                    Priority = 100,
                    Route = new Route(
                        "privacy-policy",
                        new RouteValueDictionary {
                            {"area",areaName},
                            {"controller", "Home"},
                            {"action", "Index"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", areaName}
                        },
                        new MvcRouteHandler()
                    )
                }
            };
        }
    }
}
