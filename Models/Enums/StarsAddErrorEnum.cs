using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StarsAddErrorEnum>))]
public sealed record StarsAddErrorEnum : StringEnum<StarsAddErrorEnum>
{
    private StarsAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly StarsAddErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly StarsAddErrorEnum MessageNotFound = new("message_not_found");

    public static readonly StarsAddErrorEnum FileNotFound = new("file_not_found");

    public static readonly StarsAddErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly StarsAddErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly StarsAddErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly StarsAddErrorEnum AlreadyStarred = new("already_starred");

    public static readonly StarsAddErrorEnum NotAuthed = new("not_authed");

    public static readonly StarsAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly StarsAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly StarsAddErrorEnum TokenRevoked = new("token_revoked");

    public static readonly StarsAddErrorEnum NoPermission = new("no_permission");

    public static readonly StarsAddErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly StarsAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly StarsAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly StarsAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly StarsAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly StarsAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly StarsAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly StarsAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly StarsAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly StarsAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly StarsAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly StarsAddErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly StarsAddErrorEnum FatalError = new("fatal_error");

    public static StarsAddErrorEnum FromValue(string value) => FromValueCore(value);
}
