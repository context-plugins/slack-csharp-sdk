using System.Net.Http;

namespace Slack.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}