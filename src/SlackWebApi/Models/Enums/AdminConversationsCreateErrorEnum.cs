using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsCreateErrorEnum>))]
public sealed record AdminConversationsCreateErrorEnum : OpenStringEnum<AdminConversationsCreateErrorEnum>
{
    private AdminConversationsCreateErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsCreateErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsCreateErrorEnum NameTaken = new("name_taken");

    public static readonly AdminConversationsCreateErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsCreateErrorEnum TeamNotFound = new("team_not_found");

    public static readonly AdminConversationsCreateErrorEnum InvalidTeam = new("invalid_team");

    public static readonly AdminConversationsCreateErrorEnum InvalidName = new("invalid_name");

    public static readonly AdminConversationsCreateErrorEnum CouldNotCreateChannel = new("could_not_create_channel");

    public static readonly AdminConversationsCreateErrorEnum TeamIdOrOrgRequired = new("team_id_or_org_required");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNameTaken,
        Func<TResult> onRestrictedAction,
        Func<TResult> onTeamNotFound,
        Func<TResult> onInvalidTeam,
        Func<TResult> onInvalidName,
        Func<TResult> onCouldNotCreateChannel,
        Func<TResult> onTeamIdOrOrgRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NameTaken => onNameTaken(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == TeamNotFound => onTeamNotFound(),
            _ when this == InvalidTeam => onInvalidTeam(),
            _ when this == InvalidName => onInvalidName(),
            _ when this == CouldNotCreateChannel => onCouldNotCreateChannel(),
            _ when this == TeamIdOrOrgRequired => onTeamIdOrOrgRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNameTaken,
        Action onRestrictedAction,
        Action onTeamNotFound,
        Action onInvalidTeam,
        Action onInvalidName,
        Action onCouldNotCreateChannel,
        Action onTeamIdOrOrgRequired,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NameTaken) onNameTaken();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == TeamNotFound) onTeamNotFound();
        else if (this == InvalidTeam) onInvalidTeam();
        else if (this == InvalidName) onInvalidName();
        else if (this == CouldNotCreateChannel) onCouldNotCreateChannel();
        else if (this == TeamIdOrOrgRequired) onTeamIdOrOrgRequired();
        else otherwise(Value);
    }
}
