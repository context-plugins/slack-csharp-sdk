using System.Threading;
using System.Threading.Tasks;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}