using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsHistoryErrorEnum>))]
public sealed record ConversationsHistoryErrorEnum : StringEnum<ConversationsHistoryErrorEnum>
{
    private ConversationsHistoryErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsHistoryErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsHistoryErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsHistoryErrorEnum InvalidTsLatest = new("invalid_ts_latest");

    public static readonly ConversationsHistoryErrorEnum InvalidTsOldest = new("invalid_ts_oldest");

    public static readonly ConversationsHistoryErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsHistoryErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsHistoryErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsHistoryErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsHistoryErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsHistoryErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsHistoryErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsHistoryErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsHistoryErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsHistoryErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsHistoryErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsHistoryErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsHistoryErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsHistoryErrorEnum FromValue(string value) => FromValueCore(value);
}
