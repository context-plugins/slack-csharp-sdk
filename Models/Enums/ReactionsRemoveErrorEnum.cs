using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsRemoveErrorEnum>))]
public sealed record ReactionsRemoveErrorEnum : StringEnum<ReactionsRemoveErrorEnum>
{
    private ReactionsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly ReactionsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly ReactionsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsRemoveErrorEnum InvalidName = new("invalid_name");

    public static readonly ReactionsRemoveErrorEnum NoReaction = new("no_reaction");

    public static readonly ReactionsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsRemoveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsRemoveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsRemoveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ReactionsRemoveErrorEnum FatalError = new("fatal_error");

    public static ReactionsRemoveErrorEnum FromValue(string value) => FromValueCore(value);
}
