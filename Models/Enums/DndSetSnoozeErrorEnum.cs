using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndSetSnoozeErrorEnum>))]
public sealed record DndSetSnoozeErrorEnum : StringEnum<DndSetSnoozeErrorEnum>
{
    private DndSetSnoozeErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndSetSnoozeErrorEnum MissingDuration = new("missing_duration");

    public static readonly DndSetSnoozeErrorEnum SnoozeFailed = new("snooze_failed");

    public static readonly DndSetSnoozeErrorEnum NotAuthed = new("not_authed");

    public static readonly DndSetSnoozeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndSetSnoozeErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndSetSnoozeErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndSetSnoozeErrorEnum NoPermission = new("no_permission");

    public static readonly DndSetSnoozeErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndSetSnoozeErrorEnum UserIsBot = new("user_is_bot");

    public static readonly DndSetSnoozeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndSetSnoozeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndSetSnoozeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndSetSnoozeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndSetSnoozeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndSetSnoozeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndSetSnoozeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndSetSnoozeErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndSetSnoozeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndSetSnoozeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndSetSnoozeErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndSetSnoozeErrorEnum TooLong = new("too_long");

    public static readonly DndSetSnoozeErrorEnum FatalError = new("fatal_error");

    public static DndSetSnoozeErrorEnum FromValue(string value) => FromValueCore(value);
}
