namespace Course.Route.CustomRouteConstraints;

public class PositiveIntegerRouteConstraint : IRouteConstraint
{
    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        if (values.TryGetValue(routeKey, out var value) && value != null)
        {
            if (int.TryParse(value.ToString(), out int intValue))
            {
                return intValue > 0; // Vérifie si la valeur est un entier positif.
            }
        }

        return false; // La valeur du paramètre ne correspond pas à un entier positif.
    }
}