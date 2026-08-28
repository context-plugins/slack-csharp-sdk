using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StarsRemoveErrorEnum>))]
public sealed record StarsRemoveErrorEnum : StringEnum<StarsRemoveErrorEnum>
{
    private StarsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly StarsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly StarsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly StarsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly StarsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly StarsRemoveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly StarsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly StarsRemoveErrorEnum NotStarred = new("not_starred");

    public static readonly StarsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly StarsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly StarsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly StarsRemoveErrorEnum TokenRevoked = new("token_revoked");

    public static readonly StarsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly StarsRemoveErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly StarsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly StarsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly StarsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly StarsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly StarsRemoveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly StarsRemoveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly StarsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly StarsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly StarsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly StarsRemoveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly StarsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly StarsRemoveErrorEnum FatalError = new("fatal_error");

    public static StarsRemoveErrorEnum FromValue(string value) => FromValueCore(value);
}
