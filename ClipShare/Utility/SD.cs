using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ClipShare.Utility
{
    public static class SD
    {
        public static string IsActive(this IHtmlHelper helper, string action, string controller, string cssClass = "active")
        {
            var routeData = helper.ViewContext.RouteData;
            var routeAction = routeData.Values["action"]?.ToString();
            var routeController = routeData.Values["controller"]?.ToString();

            var returnActive = controller == routeController && action == routeAction;

            return returnActive ? cssClass : string.Empty;
        }
    }
}
