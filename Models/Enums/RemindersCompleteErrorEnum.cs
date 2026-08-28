using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RemindersCompleteErrorEnum>))]
public sealed record RemindersCompleteErrorEnum : StringEnum<RemindersCompleteErrorEnum>
{
    private RemindersCompleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly RemindersCompleteErrorEnum NotFound = new("not_found");

    public static readonly RemindersCompleteErrorEnum CannotCompleteRecurring = new("cannot_complete_recurring");

    public static readonly RemindersCompleteErrorEnum CannotCompleteOthers = new("cannot_complete_others");

    public static readonly RemindersCompleteErrorEnum NotAuthed = new("not_authed");

    public static readonly RemindersCompleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RemindersCompleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly RemindersCompleteErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RemindersCompleteErrorEnum NoPermission = new("no_permission");

    public static readonly RemindersCompleteErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly RemindersCompleteErrorEnum UserIsBot = new("user_is_bot");

    public static readonly RemindersCompleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RemindersCompleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RemindersCompleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RemindersCompleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RemindersCompleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RemindersCompleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RemindersCompleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RemindersCompleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly RemindersCompleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RemindersCompleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RemindersCompleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RemindersCompleteErrorEnum FatalError = new("fatal_error");

    public static RemindersCompleteErrorEnum FromValue(string value) => FromValueCore(value);
}
