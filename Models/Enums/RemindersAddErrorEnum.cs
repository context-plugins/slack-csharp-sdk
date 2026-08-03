using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RemindersAddErrorEnum>))]
public sealed record RemindersAddErrorEnum : StringEnum<RemindersAddErrorEnum>
{
    private RemindersAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly RemindersAddErrorEnum CannotParse = new("cannot_parse");

    public static readonly RemindersAddErrorEnum UserNotFound = new("user_not_found");

    public static readonly RemindersAddErrorEnum CannotAddBot = new("cannot_add_bot");

    public static readonly RemindersAddErrorEnum CannotAddSlackbot = new("cannot_add_slackbot");

    public static readonly RemindersAddErrorEnum CannotAddOthers = new("cannot_add_others");

    public static readonly RemindersAddErrorEnum CannotAddOthersRecurring = new("cannot_add_others_recurring");

    public static readonly RemindersAddErrorEnum NotAuthed = new("not_authed");

    public static readonly RemindersAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RemindersAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly RemindersAddErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RemindersAddErrorEnum NoPermission = new("no_permission");

    public static readonly RemindersAddErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly RemindersAddErrorEnum UserIsBot = new("user_is_bot");

    public static readonly RemindersAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RemindersAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RemindersAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RemindersAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RemindersAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RemindersAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RemindersAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RemindersAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly RemindersAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RemindersAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RemindersAddErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RemindersAddErrorEnum FatalError = new("fatal_error");

    public static RemindersAddErrorEnum FromValue(string value) => FromValueCore(value);
}
