using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatGetPermalinkErrorEnum>))]
public sealed record ChatGetPermalinkErrorEnum : StringEnum<ChatGetPermalinkErrorEnum>
{
    private ChatGetPermalinkErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatGetPermalinkErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatGetPermalinkErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatGetPermalinkErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatGetPermalinkErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatGetPermalinkErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatGetPermalinkErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatGetPermalinkErrorEnum NoPermission = new("no_permission");

    public static readonly ChatGetPermalinkErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatGetPermalinkErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatGetPermalinkErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatGetPermalinkErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatGetPermalinkErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatGetPermalinkErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatGetPermalinkErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatGetPermalinkErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatGetPermalinkErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatGetPermalinkErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatGetPermalinkErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatGetPermalinkErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatGetPermalinkErrorEnum FatalError = new("fatal_error");

    public static ChatGetPermalinkErrorEnum FromValue(string value) => FromValueCore(value);
}
