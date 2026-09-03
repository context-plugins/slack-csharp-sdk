using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersConversationsErrorEnum>))]
public sealed record UsersConversationsErrorEnum : StringEnum<UsersConversationsErrorEnum>
{
    private UsersConversationsErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersConversationsErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly UsersConversationsErrorEnum MissingScope = new("missing_scope");

    public static readonly UsersConversationsErrorEnum InvalidTypes = new("invalid_types");

    public static readonly UsersConversationsErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly UsersConversationsErrorEnum InvalidLimit = new("invalid_limit");

    public static readonly UsersConversationsErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersConversationsErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersConversationsErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersConversationsErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersConversationsErrorEnum NoPermission = new("no_permission");

    public static readonly UsersConversationsErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersConversationsErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersConversationsErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersConversationsErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersConversationsErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersConversationsErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersConversationsErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersConversationsErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersConversationsErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersConversationsErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersConversationsErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersConversationsErrorEnum FatalError = new("fatal_error");

    public static UsersConversationsErrorEnum FromValue(string value) => FromValueCore(value);
}
