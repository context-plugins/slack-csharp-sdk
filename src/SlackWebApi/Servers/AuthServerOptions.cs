using SlackWebApi.Core.Models;

namespace SlackWebApi.Servers;

public class AuthServerOptions
{
    public ProductionOptions Production { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://slack.com/oauth/v2";
    }
}
