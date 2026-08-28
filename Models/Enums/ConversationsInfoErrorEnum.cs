using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsInfoErrorEnum>))]
public sealed record ConversationsInfoErrorEnum : StringEnum<ConversationsInfoErrorEnum>
{
    private ConversationsInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsInfoErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsInfoErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
