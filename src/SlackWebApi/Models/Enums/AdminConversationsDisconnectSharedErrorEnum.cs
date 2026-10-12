using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsDisconnectSharedErrorEnum>))]
public sealed record AdminConversationsDisconnectSharedErrorEnum : OpenStringEnum<AdminConversationsDisconnectSharedErrorEnum>
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

    public static readonly AdminConversationsDisconnectSharedErrorEnum LeavingTeamNotInChannel = new(
        "leaving_team_not_in_channel");

    public static readonly AdminConversationsDisconnectSharedErrorEnum NoTeamsToDisconnect = new(
        "no_teams_to_disconnect");

    public static readonly AdminConversationsDisconnectSharedErrorEnum LeavingTeamRequired = new(
        "leaving_team_required");

    public static readonly AdminConversationsDisconnectSharedErrorEnum CannotKickTeam = new("cannot_kick_team");

    public static readonly AdminConversationsDisconnectSharedErrorEnum CannotKickHomeTeam = new(
        "cannot_kick_home_team");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNotAnAdmin,
        Func<TResult> onNotAnEnterprise,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNotSupported,
        Func<TResult> onTeamNotFound,
        Func<TResult> onRestrictedAction,
        Func<TResult> onMissingScope,
        Func<TResult> onLeavingTeamNotInChannel,
        Func<TResult> onNoTeamsToDisconnect,
        Func<TResult> onLeavingTeamRequired,
        Func<TResult> onCannotKickTeam,
        Func<TResult> onCannotKickHomeTeam,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NotAnAdmin => onNotAnAdmin(),
            _ when this == NotAnEnterprise => onNotAnEnterprise(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotSupported => onNotSupported(),
            _ when this == TeamNotFound => onTeamNotFound(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == LeavingTeamNotInChannel => onLeavingTeamNotInChannel(),
            _ when this == NoTeamsToDisconnect => onNoTeamsToDisconnect(),
            _ when this == LeavingTeamRequired => onLeavingTeamRequired(),
            _ when this == CannotKickTeam => onCannotKickTeam(),
            _ when this == CannotKickHomeTeam => onCannotKickHomeTeam(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNotAnAdmin,
        Action onNotAnEnterprise,
        Action onChannelNotFound,
        Action onNotSupported,
        Action onTeamNotFound,
        Action onRestrictedAction,
        Action onMissingScope,
        Action onLeavingTeamNotInChannel,
        Action onNoTeamsToDisconnect,
        Action onLeavingTeamRequired,
        Action onCannotKickTeam,
        Action onCannotKickHomeTeam,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NotAnAdmin) onNotAnAdmin();
        else if (this == NotAnEnterprise) onNotAnEnterprise();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotSupported) onNotSupported();
        else if (this == TeamNotFound) onTeamNotFound();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == MissingScope) onMissingScope();
        else if (this == LeavingTeamNotInChannel) onLeavingTeamNotInChannel();
        else if (this == NoTeamsToDisconnect) onNoTeamsToDisconnect();
        else if (this == LeavingTeamRequired) onLeavingTeamRequired();
        else if (this == CannotKickTeam) onCannotKickTeam();
        else if (this == CannotKickHomeTeam) onCannotKickHomeTeam();
        else otherwise(Value);
    }
}
