using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsInviteErrorEnum>))]
public sealed record ConversationsInviteErrorEnum : StringEnum<ConversationsInviteErrorEnum>
{
    private ConversationsInviteErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsInviteErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsInviteErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsInviteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsInviteErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsInviteErrorEnum NoUser = new("no_user");

    public static readonly ConversationsInviteErrorEnum CantInviteSelf = new("cant_invite_self");

    public static readonly ConversationsInviteErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsInviteErrorEnum AlreadyInChannel = new("already_in_channel");

    public static readonly ConversationsInviteErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsInviteErrorEnum CantInvite = new("cant_invite");

    public static readonly ConversationsInviteErrorEnum TooManyUsers = new("too_many_users");

    public static readonly ConversationsInviteErrorEnum UraMaxChannels = new("ura_max_channels");

    public static readonly ConversationsInviteErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsInviteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsInviteErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsInviteErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsInviteErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsInviteErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsInviteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsInviteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsInviteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsInviteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsInviteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsInviteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsInviteErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsInviteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsInviteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsInviteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsInviteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsInviteErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsInviteErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static ConversationsInviteErrorEnum FromValue(string value) => FromValueCore(value);
}
