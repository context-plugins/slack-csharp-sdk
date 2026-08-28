using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsJoinErrorEnum>))]
public sealed record ConversationsJoinErrorEnum : StringEnum<ConversationsJoinErrorEnum>
{
    private ConversationsJoinErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsJoinErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsJoinErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsJoinErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsJoinErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsJoinErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsJoinErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsJoinErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsJoinErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsJoinErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsJoinErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsJoinErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsJoinErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsJoinErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsJoinErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsJoinErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsJoinErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsJoinErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsJoinErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsJoinErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsJoinErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsJoinErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsJoinErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsJoinErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static ConversationsJoinErrorEnum FromValue(string value) => FromValueCore(value);
}
