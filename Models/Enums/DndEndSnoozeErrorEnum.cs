using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndEndSnoozeErrorEnum>))]
public sealed record DndEndSnoozeErrorEnum : StringEnum<DndEndSnoozeErrorEnum>
{
    private DndEndSnoozeErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndEndSnoozeErrorEnum SnoozeNotActive = new("snooze_not_active");

    public static readonly DndEndSnoozeErrorEnum SnoozeEndFailed = new("snooze_end_failed");

    public static readonly DndEndSnoozeErrorEnum NotAuthed = new("not_authed");

    public static readonly DndEndSnoozeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndEndSnoozeErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndEndSnoozeErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndEndSnoozeErrorEnum NoPermission = new("no_permission");

    public static readonly DndEndSnoozeErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndEndSnoozeErrorEnum UserIsBot = new("user_is_bot");

    public static readonly DndEndSnoozeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndEndSnoozeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndEndSnoozeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndEndSnoozeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndEndSnoozeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndEndSnoozeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndEndSnoozeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndEndSnoozeErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndEndSnoozeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndEndSnoozeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndEndSnoozeErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndEndSnoozeErrorEnum FatalError = new("fatal_error");

    public static DndEndSnoozeErrorEnum FromValue(string value) => FromValueCore(value);
}
