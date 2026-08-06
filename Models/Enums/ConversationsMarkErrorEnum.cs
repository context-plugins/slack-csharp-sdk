using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsMarkErrorEnum>))]
public sealed record ConversationsMarkErrorEnum : StringEnum<ConversationsMarkErrorEnum>
{
    private ConversationsMarkErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsMarkErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsMarkErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsMarkErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsMarkErrorEnum InvalidTimestamp = new("invalid_timestamp");

    public static readonly ConversationsMarkErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsMarkErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsMarkErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsMarkErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsMarkErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsMarkErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsMarkErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsMarkErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsMarkErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsMarkErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsMarkErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsMarkErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsMarkErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsMarkErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsMarkErrorEnum NotAllowedTokenType = new("not_allowed_token_type");

    public static ConversationsMarkErrorEnum FromValue(string value) => FromValueCore(value);
}
