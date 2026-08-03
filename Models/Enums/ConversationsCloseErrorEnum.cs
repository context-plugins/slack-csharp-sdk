using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsCloseErrorEnum>))]
public sealed record ConversationsCloseErrorEnum : StringEnum<ConversationsCloseErrorEnum>
{
    private ConversationsCloseErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsCloseErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsCloseErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsCloseErrorEnum UserDoesNotOwnChannel = new("user_does_not_own_channel");

    public static readonly ConversationsCloseErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsCloseErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsCloseErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsCloseErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsCloseErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsCloseErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsCloseErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsCloseErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsCloseErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsCloseErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsCloseErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsCloseErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsCloseErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsCloseErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsCloseErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsCloseErrorEnum FromValue(string value) => FromValueCore(value);
}
