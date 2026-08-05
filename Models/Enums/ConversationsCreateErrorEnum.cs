using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsCreateErrorEnum>))]
public sealed record ConversationsCreateErrorEnum : StringEnum<ConversationsCreateErrorEnum>
{
    private ConversationsCreateErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsCreateErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsCreateErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsCreateErrorEnum NameTaken = new("name_taken");

    public static readonly ConversationsCreateErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ConversationsCreateErrorEnum NoChannel = new("no_channel");

    public static readonly ConversationsCreateErrorEnum InvalidNameRequired = new("invalid_name_required");

    public static readonly ConversationsCreateErrorEnum InvalidNamePunctuation = new("invalid_name_punctuation");

    public static readonly ConversationsCreateErrorEnum InvalidNameMaxlength = new("invalid_name_maxlength");

    public static readonly ConversationsCreateErrorEnum InvalidNameSpecials = new("invalid_name_specials");

    public static readonly ConversationsCreateErrorEnum InvalidName = new("invalid_name");

    public static readonly ConversationsCreateErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsCreateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsCreateErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsCreateErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsCreateErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsCreateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsCreateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsCreateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsCreateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsCreateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsCreateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsCreateErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsCreateErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsCreateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsCreateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsCreateErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsCreateErrorEnum FromValue(string value) => FromValueCore(value);
}
