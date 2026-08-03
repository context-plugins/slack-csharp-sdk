using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsOpenErrorEnum>))]
public sealed record ConversationsOpenErrorEnum : StringEnum<ConversationsOpenErrorEnum>
{
    private ConversationsOpenErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsOpenErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsOpenErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsOpenErrorEnum UserNotVisible = new("user_not_visible");

    public static readonly ConversationsOpenErrorEnum UserDisabled = new("user_disabled");

    public static readonly ConversationsOpenErrorEnum UsersListNotSupplied = new("users_list_not_supplied");

    public static readonly ConversationsOpenErrorEnum NotEnoughUsers = new("not_enough_users");

    public static readonly ConversationsOpenErrorEnum TooManyUsers = new("too_many_users");

    public static readonly ConversationsOpenErrorEnum InvalidUserCombination = new("invalid_user_combination");

    public static readonly ConversationsOpenErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsOpenErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsOpenErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsOpenErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsOpenErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsOpenErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsOpenErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsOpenErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsOpenErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsOpenErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsOpenErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsOpenErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsOpenErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsOpenErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsOpenErrorEnum ChannelNotFound = new("channel_not_found");

    public static ConversationsOpenErrorEnum FromValue(string value) => FromValueCore(value);
}
