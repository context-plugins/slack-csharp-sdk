using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndInfoErrorEnum>))]
public sealed record DndInfoErrorEnum : StringEnum<DndInfoErrorEnum>
{
    private DndInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndInfoErrorEnum UserNotFound = new("user_not_found");

    public static readonly DndInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly DndInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndInfoErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndInfoErrorEnum NoPermission = new("no_permission");

    public static readonly DndInfoErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndInfoErrorEnum FatalError = new("fatal_error");

    public static DndInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
