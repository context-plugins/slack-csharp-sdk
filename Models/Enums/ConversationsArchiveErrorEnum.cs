using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsArchiveErrorEnum>))]
public sealed record ConversationsArchiveErrorEnum : StringEnum<ConversationsArchiveErrorEnum>
{
    private ConversationsArchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsArchiveErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsArchiveErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsArchiveErrorEnum NotSupported = new("not_supported");

    public static readonly ConversationsArchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsArchiveErrorEnum AlreadyArchived = new("already_archived");

    public static readonly ConversationsArchiveErrorEnum CantArchiveGeneral = new("cant_archive_general");

    public static readonly ConversationsArchiveErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ConversationsArchiveErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsArchiveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsArchiveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsArchiveErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsArchiveErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsArchiveErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsArchiveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsArchiveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsArchiveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsArchiveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsArchiveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsArchiveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsArchiveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsArchiveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsArchiveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsArchiveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsArchiveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsArchiveErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsArchiveErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static ConversationsArchiveErrorEnum FromValue(string value) => FromValueCore(value);
}
