using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsUnarchiveErrorEnum>))]
public sealed record ConversationsUnarchiveErrorEnum : StringEnum<ConversationsUnarchiveErrorEnum>
{
    private ConversationsUnarchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsUnarchiveErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsUnarchiveErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsUnarchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsUnarchiveErrorEnum NotArchived = new("not_archived");

    public static readonly ConversationsUnarchiveErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsUnarchiveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsUnarchiveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsUnarchiveErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsUnarchiveErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsUnarchiveErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsUnarchiveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsUnarchiveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsUnarchiveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsUnarchiveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsUnarchiveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsUnarchiveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsUnarchiveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsUnarchiveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsUnarchiveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsUnarchiveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsUnarchiveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsUnarchiveErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsUnarchiveErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static ConversationsUnarchiveErrorEnum FromValue(string value) => FromValueCore(value);
}
