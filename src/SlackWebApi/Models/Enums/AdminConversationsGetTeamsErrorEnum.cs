using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsGetTeamsErrorEnum>))]
public sealed record AdminConversationsGetTeamsErrorEnum : OpenStringEnum<AdminConversationsGetTeamsErrorEnum>
{
    private AdminConversationsGetTeamsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsGetTeamsErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsGetTeamsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsGetTeamsErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsGetTeamsErrorEnum UnsupportedTeamType = new("unsupported_team_type");

    public static readonly AdminConversationsGetTeamsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsGetTeamsErrorEnum CouldNotGetTeams = new("could_not_get_teams");

    public static readonly AdminConversationsGetTeamsErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly AdminConversationsGetTeamsErrorEnum InvalidLimit = new("invalid_limit");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onUnsupportedTeamType,
        Func<TResult> onRestrictedAction,
        Func<TResult> onCouldNotGetTeams,
        Func<TResult> onInvalidCursor,
        Func<TResult> onInvalidLimit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == UnsupportedTeamType => onUnsupportedTeamType(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == CouldNotGetTeams => onCouldNotGetTeams(),
            _ when this == InvalidCursor => onInvalidCursor(),
            _ when this == InvalidLimit => onInvalidLimit(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onUnsupportedTeamType,
        Action onRestrictedAction,
        Action onCouldNotGetTeams,
        Action onInvalidCursor,
        Action onInvalidLimit,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == UnsupportedTeamType) onUnsupportedTeamType();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == CouldNotGetTeams) onCouldNotGetTeams();
        else if (this == InvalidCursor) onInvalidCursor();
        else if (this == InvalidLimit) onInvalidLimit();
        else otherwise(Value);
    }
}
