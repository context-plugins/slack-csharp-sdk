using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatUnfurlErrorEnum>))]
public sealed record ChatUnfurlErrorEnum : StringEnum<ChatUnfurlErrorEnum>
{
    private ChatUnfurlErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatUnfurlErrorEnum CannotUnfurlUrl = new("cannot_unfurl_url");

    public static readonly ChatUnfurlErrorEnum CannotFindService = new("cannot_find_service");

    public static readonly ChatUnfurlErrorEnum MissingUnfurls = new("missing_unfurls");

    public static readonly ChatUnfurlErrorEnum CannotPrompt = new("cannot_prompt");

    public static readonly ChatUnfurlErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatUnfurlErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatUnfurlErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatUnfurlErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatUnfurlErrorEnum NoPermission = new("no_permission");

    public static readonly ChatUnfurlErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatUnfurlErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ChatUnfurlErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatUnfurlErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatUnfurlErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatUnfurlErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatUnfurlErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatUnfurlErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatUnfurlErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatUnfurlErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatUnfurlErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatUnfurlErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatUnfurlErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatUnfurlErrorEnum FatalError = new("fatal_error");

    public static ChatUnfurlErrorEnum FromValue(string value) => FromValueCore(value);
}
