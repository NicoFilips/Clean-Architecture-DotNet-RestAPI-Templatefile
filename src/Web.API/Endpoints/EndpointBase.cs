using Carter;
using ErrorOr;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Web.API.Endpoints;

public abstract class EndpointBase : ICarterModule
{
    public abstract void AddRoutes(IEndpointRouteBuilder app);

    protected IResult Problem(List<Error> errors)
    {
        if (errors.Count is 0)
            return Results.Problem();

        if (errors.All(error => error.Type == ErrorType.Validation)) return ValidationProblem(errors);

        int statusCode = Problem(errors[0]);

        return Results.Problem(statusCode: statusCode, title: errors[0].Description);
    }

    private static int Problem(Error error)
    {
        int statusCode = error.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
        return statusCode;
    }

    private static IResult ValidationProblem(List<Error> errors)
    {
        var modelStateDictionary = errors.ToDictionary(error => error.Code, error => new[] { error.Description });
        return Results.ValidationProblem(modelStateDictionary);
    }
}
