using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsDisconnectSharedErrorEnum>))]
public sealed record AdminConversationsDisconnectSharedErrorEnum : StringEnum<AdminConversationsDisconnectSharedErrorEnum>
{
    private AdminConversationsDisconnectSharedErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsDisconnectSharedErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsDisconnectSharedErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsDisconnectSharedErrorEnum NotAnEnterprise = new("not_an_enterprise");

    public static readonly AdminConversationsDisconnectSharedErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsDisconnectSharedErrorEnum NotSupported = new("not_supported");

    public static readonly AdminConversationsDisconnectSharedErrorEnum TeamNotFound = new("team_not_found");

    public static readonly AdminConversationsDisconnectSharedErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsDisconnectSharedErrorEnum MissingScope = new("missing_scope");

    public static readonly AdminConversationsDisconnectSharedErrorEnum LeavingTeamNotInChannel = new("leaving_team_not_in_channel");

    public static readonly AdminConversationsDisconnectSharedErrorEnum NoTeamsToDisconnect = new("no_teams_to_disconnect");

    public static readonly AdminConversationsDisconnectSharedErrorEnum LeavingTeamRequired = new("leaving_team_required");

    public static readonly AdminConversationsDisconnectSharedErrorEnum CannotKickTeam = new("cannot_kick_team");

    public static readonly AdminConversationsDisconnectSharedErrorEnum CannotKickHomeTeam = new("cannot_kick_home_team");

    public static AdminConversationsDisconnectSharedErrorEnum FromValue(string value) => FromValueCore(value);
}
