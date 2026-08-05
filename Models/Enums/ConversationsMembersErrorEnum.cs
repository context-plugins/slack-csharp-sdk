using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsMembersErrorEnum>))]
public sealed record ConversationsMembersErrorEnum : StringEnum<ConversationsMembersErrorEnum>
{
    private ConversationsMembersErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsMembersErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsMembersErrorEnum InvalidLimit = new("invalid_limit");

    public static readonly ConversationsMembersErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly ConversationsMembersErrorEnum FetchMembersFailed = new("fetch_members_failed");

    public static readonly ConversationsMembersErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsMembersErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsMembersErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsMembersErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsMembersErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsMembersErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsMembersErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsMembersErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsMembersErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsMembersErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsMembersErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsMembersErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsMembersErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsMembersErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsMembersErrorEnum FromValue(string value) => FromValueCore(value);
}
