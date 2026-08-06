using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsRepliesErrorEnum>))]
public sealed record ConversationsRepliesErrorEnum : StringEnum<ConversationsRepliesErrorEnum>
{
    private ConversationsRepliesErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsRepliesErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsRepliesErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsRepliesErrorEnum ThreadNotFound = new("thread_not_found");

    public static readonly ConversationsRepliesErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsRepliesErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsRepliesErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsRepliesErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsRepliesErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsRepliesErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsRepliesErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsRepliesErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsRepliesErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsRepliesErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsRepliesErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsRepliesErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsRepliesErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsRepliesErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsRepliesErrorEnum FromValue(string value) => FromValueCore(value);
}
