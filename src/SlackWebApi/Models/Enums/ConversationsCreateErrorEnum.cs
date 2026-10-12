using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsCreateErrorEnum>))]
public sealed record ConversationsCreateErrorEnum : OpenStringEnum<ConversationsCreateErrorEnum>
{
    private ConversationsCreateErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsCreateErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

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

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onNameTaken,
        Func<TResult> onRestrictedAction,
        Func<TResult> onNoChannel,
        Func<TResult> onInvalidNameRequired,
        Func<TResult> onInvalidNamePunctuation,
        Func<TResult> onInvalidNameMaxlength,
        Func<TResult> onInvalidNameSpecials,
        Func<TResult> onInvalidName,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onUserIsBot,
        Func<TResult> onUserIsRestricted,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == NameTaken => onNameTaken(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == NoChannel => onNoChannel(),
            _ when this == InvalidNameRequired => onInvalidNameRequired(),
            _ when this == InvalidNamePunctuation => onInvalidNamePunctuation(),
            _ when this == InvalidNameMaxlength => onInvalidNameMaxlength(),
            _ when this == InvalidNameSpecials => onInvalidNameSpecials(),
            _ when this == InvalidName => onInvalidName(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == UserIsRestricted => onUserIsRestricted(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onNameTaken,
        Action onRestrictedAction,
        Action onNoChannel,
        Action onInvalidNameRequired,
        Action onInvalidNamePunctuation,
        Action onInvalidNameMaxlength,
        Action onInvalidNameSpecials,
        Action onInvalidName,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onUserIsBot,
        Action onUserIsRestricted,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onTeamAddedToOrg,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == NameTaken) onNameTaken();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == NoChannel) onNoChannel();
        else if (this == InvalidNameRequired) onInvalidNameRequired();
        else if (this == InvalidNamePunctuation) onInvalidNamePunctuation();
        else if (this == InvalidNameMaxlength) onInvalidNameMaxlength();
        else if (this == InvalidNameSpecials) onInvalidNameSpecials();
        else if (this == InvalidName) onInvalidName();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == UserIsRestricted) onUserIsRestricted();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else otherwise(Value);
    }
}
