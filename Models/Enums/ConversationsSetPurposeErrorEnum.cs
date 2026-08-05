using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsSetPurposeErrorEnum>))]
public sealed record ConversationsSetPurposeErrorEnum : StringEnum<ConversationsSetPurposeErrorEnum>
{
    private ConversationsSetPurposeErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsSetPurposeErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsSetPurposeErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsSetPurposeErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsSetPurposeErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsSetPurposeErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsSetPurposeErrorEnum TooLong = new("too_long");

    public static readonly ConversationsSetPurposeErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsSetPurposeErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsSetPurposeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsSetPurposeErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsSetPurposeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsSetPurposeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsSetPurposeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsSetPurposeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsSetPurposeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsSetPurposeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsSetPurposeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsSetPurposeErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsSetPurposeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsSetPurposeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsSetPurposeErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsSetPurposeErrorEnum FromValue(string value) => FromValueCore(value);
}
