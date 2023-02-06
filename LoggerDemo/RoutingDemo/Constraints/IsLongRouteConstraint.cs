namespace RoutingDemo.Constraints
{
    public class IsLongRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (routeDirection == RouteDirection.IncomingRequest)
            {
                string val = values[routeKey]?.ToString();
                if (long.TryParse(val, out long longValue))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
