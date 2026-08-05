using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatDeleteErrorEnum>))]
public sealed record ChatDeleteErrorEnum : StringEnum<ChatDeleteErrorEnum>
{
    private ChatDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatDeleteErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatDeleteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatDeleteErrorEnum CantDeleteMessage = new("cant_delete_message");

    public static readonly ChatDeleteErrorEnum ComplianceExportsPreventDeletion = new("compliance_exports_prevent_deletion");

    public static readonly ChatDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatDeleteErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly ChatDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatDeleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatDeleteErrorEnum FatalError = new("fatal_error");

    public static ChatDeleteErrorEnum FromValue(string value) => FromValueCore(value);
}
