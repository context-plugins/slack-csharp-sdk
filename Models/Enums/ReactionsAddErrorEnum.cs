using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsAddErrorEnum>))]
public sealed record ReactionsAddErrorEnum : StringEnum<ReactionsAddErrorEnum>
{
    private ReactionsAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsAddErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsAddErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsAddErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsAddErrorEnum InvalidName = new("invalid_name");

    public static readonly ReactionsAddErrorEnum AlreadyReacted = new("already_reacted");

    public static readonly ReactionsAddErrorEnum TooManyEmoji = new("too_many_emoji");

    public static readonly ReactionsAddErrorEnum TooManyReactions = new("too_many_reactions");

    public static readonly ReactionsAddErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsAddErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsAddErrorEnum UpgradeRequired = new("upgrade_required");

    public static ReactionsAddErrorEnum FromValue(string value) => FromValueCore(value);
}
