using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsSearchErrorEnum>))]
public sealed record AdminConversationsSearchErrorEnum : StringEnum<AdminConversationsSearchErrorEnum>
{
    private AdminConversationsSearchErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsSearchErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsSearchErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsSearchErrorEnum NotAnEnterprise = new("not_an_enterprise");

    public static readonly AdminConversationsSearchErrorEnum TeamNotFound = new("team_not_found");

    public static readonly AdminConversationsSearchErrorEnum NotAllowed = new("not_allowed");

    public static readonly AdminConversationsSearchErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AdminConversationsSearchErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly AdminConversationsSearchErrorEnum InvalidSearchChannelType = new("invalid_search_channel_type");

    public static readonly AdminConversationsSearchErrorEnum InvalidSort = new("invalid_sort");

    public static readonly AdminConversationsSearchErrorEnum InvalidSortDir = new("invalid_sort_dir");

    public static AdminConversationsSearchErrorEnum FromValue(string value) => FromValueCore(value);
}
