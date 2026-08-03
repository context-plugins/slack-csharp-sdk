using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsRenameErrorEnum>))]
public sealed record ConversationsRenameErrorEnum : StringEnum<ConversationsRenameErrorEnum>
{
    private ConversationsRenameErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsRenameErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsRenameErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsRenameErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsRenameErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsRenameErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsRenameErrorEnum NotAuthorized = new("not_authorized");

    public static readonly ConversationsRenameErrorEnum InvalidName = new("invalid_name");

    public static readonly ConversationsRenameErrorEnum NameTaken = new("name_taken");

    public static readonly ConversationsRenameErrorEnum InvalidNameRequired = new("invalid_name_required");

    public static readonly ConversationsRenameErrorEnum InvalidNamePunctuation = new("invalid_name_punctuation");

    public static readonly ConversationsRenameErrorEnum InvalidNameMaxlength = new("invalid_name_maxlength");

    public static readonly ConversationsRenameErrorEnum InvalidNameSpecials = new("invalid_name_specials");

    public static readonly ConversationsRenameErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsRenameErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsRenameErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsRenameErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsRenameErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsRenameErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsRenameErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsRenameErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsRenameErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsRenameErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsRenameErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsRenameErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsRenameErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsRenameErrorEnum FromValue(string value) => FromValueCore(value);
}
