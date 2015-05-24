using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "New", action = "List"}
            );

            routes.MapRoute(
              name: "first",
              url: "product/{article}",
              defaults: new { controller = "New", action = "id", name = "AB-123" },
                 constraints: new
                 {
                     name = "[A-Z]{2}-[0-9]{3}"
                 }
              );
            routes.MapRoute(
                name: "second",
                url: "product/{article}/print",
                defaults: new { controller = "New", action = "print", name = "AB-123" },
                   constraints: new
                   {
                       name = "[A-Z]{2}-[0-9]{3}"
                   }
                );
            routes.MapRoute(
              name: "third",
              url: "products/{category}/{page}",
              defaults: new { controller = "New", action = "category", category = "electronics", page = "1" },
                 constraints: new
                 {
                     category = "[a-z]+",
                     page = @"\d+"
                 }
              );
            routes.MapRoute(
              name: "fourth",
              url: "products/date/{date}/{page}",
              defaults: new { controller = "New", action = "date", date = "2003-02-03", page = "1" },
                 constraints: new
                 {
                     date = new prodRouteConstraint(),
                     //date = @"^[0-9]{4}-(((0[13578]|[13578]|1[02])-([1-9]|[0-2][0-9]|3[01]))|((2|02)-([1-9]|[0-2][0-9]))|((0[469]|[469]|11)-([1-9]|[0-2][0-9]|30)))$",
                     //[0-9]{4} - год
                     //(0[13578]|[13578]|1[02]) - месяца с 31 днем
                     //([1-9]|[0-2][0-9]|3[01]) - день с 1 по 31 число
                     //(2|02) - февраль
                     //([1-9]|[0-2][0-9]) - день с 1 по 29 число
                     //(0[469]|[469]|11) - месяца с 30 днями
                     // ([1-9]|[0-2][0-9]|30) - день с 1 по 30 число
                     page = @"\d+"
                 }
              );
           
        }
    }
}
