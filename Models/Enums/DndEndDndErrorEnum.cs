using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndEndDndErrorEnum>))]
public sealed record DndEndDndErrorEnum : StringEnum<DndEndDndErrorEnum>
{
    private DndEndDndErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndEndDndErrorEnum UnknownError = new("unknown_error");

    public static readonly DndEndDndErrorEnum NotAuthed = new("not_authed");

    public static readonly DndEndDndErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndEndDndErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndEndDndErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndEndDndErrorEnum NoPermission = new("no_permission");

    public static readonly DndEndDndErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndEndDndErrorEnum UserIsBot = new("user_is_bot");

    public static readonly DndEndDndErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndEndDndErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndEndDndErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndEndDndErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndEndDndErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndEndDndErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndEndDndErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndEndDndErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndEndDndErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndEndDndErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndEndDndErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndEndDndErrorEnum FatalError = new("fatal_error");

    public static DndEndDndErrorEnum FromValue(string value) => FromValueCore(value);
}
