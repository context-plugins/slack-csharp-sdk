using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsGetTeamsErrorEnum>))]
public sealed record AdminConversationsGetTeamsErrorEnum : StringEnum<AdminConversationsGetTeamsErrorEnum>
{
    private AdminConversationsGetTeamsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsGetTeamsErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsGetTeamsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsGetTeamsErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsGetTeamsErrorEnum UnsupportedTeamType = new("unsupported_team_type");

    public static readonly AdminConversationsGetTeamsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsGetTeamsErrorEnum CouldNotGetTeams = new("could_not_get_teams");

    public static readonly AdminConversationsGetTeamsErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly AdminConversationsGetTeamsErrorEnum InvalidLimit = new("invalid_limit");

    public static AdminConversationsGetTeamsErrorEnum FromValue(string value) => FromValueCore(value);
}
