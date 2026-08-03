using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsListErrorEnum>))]
public sealed record ConversationsListErrorEnum : StringEnum<ConversationsListErrorEnum>
{
    private ConversationsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsListErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsListErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsListErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsListErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsListErrorEnum FromValue(string value) => FromValueCore(value);
}
