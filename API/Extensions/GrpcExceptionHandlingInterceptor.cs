using BLL.Exceptions;
using Grpc.Core.Interceptors;
using Grpc.Core;
using API.Exceptions;
using Google.Rpc;
using CatalogGrpcService;

namespace API.Extensions;

public class GrpcExceptionHandlingInterceptor : Interceptor
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await base.UnaryServerHandler(request, context, continuation);
        }
        catch (Exception e)
        {
            return MapResponse<TRequest, TResponse>(e);
        }
    }

    private static TResponse MapResponse<TRequest, TResponse>(Exception ex)
    {
        var responseViewModel = ex switch
        {
            NotFoundException => new GrpcStatus
            {
                Message = ex.Message,
                StatusCode = (int)Code.NotFound
            },

            InvalidOperationException => new GrpcStatus
            {
                Message = ex.Message,
                StatusCode = (int)Code.FailedPrecondition
            },

            _ => new GrpcStatus
            {
                Message = ex.Message,
                StatusCode = (int)Code.Internal
            }
        };

        var concreteResponse = Activator.CreateInstance<TResponse>();

        concreteResponse?.GetType().GetProperty(nameof(GrpcStatus))?.SetValue(concreteResponse, responseViewModel);

        return concreteResponse;
    }
}