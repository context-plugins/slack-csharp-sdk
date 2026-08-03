using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsCreateErrorEnum>))]
public sealed record AdminConversationsCreateErrorEnum : StringEnum<AdminConversationsCreateErrorEnum>
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

    public static AdminConversationsCreateErrorEnum FromValue(string value) => FromValueCore(value);
}
